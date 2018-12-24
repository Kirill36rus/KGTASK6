using CGLib;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CGLib.Filters;
using CGLib.MyMath;
using CGLib.Lighting;
using System.Threading;


namespace CGTask6
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            mainSizeLBL.Text = string.Format("Main photo size: {0}*{1}", 500, 500);
        }
        Bitmap bmp;
        Color selectedColor;
        Photo tmp;
        Scene Scene;
        Graphics g0;
        Point[] points;
        private void OpenBTN_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() != DialogResult.OK)
                return;
            bmp = (Bitmap)Image.FromFile(ofd.FileName);
            tmp = Convertors.Bitmap2Photo(bmp);
            sizeLBL.Text = string.Format("Size: {0} {1}", tmp.Width, tmp.Height);
            widthInputTB.Text = tmp.Width.ToString();
            heightInputTB.Text = tmp.Height.ToString();
            inputPB.Image = Convertors.Photo2Bitmap(tmp);
        }

        private void ListToComboBox(ComboBox box, List<Photo> photos)
        {
            box.Items.Clear();
            for (int i = 0; i < photos.Count; i++)
                box.Items.Add(i.ToString());
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void AddBTN_Click(object sender, EventArgs e)
        {
            if (tmp == null)
                return;
            int w = Int32.Parse(widthInputTB.Text), h = Int32.Parse(heightInputTB.Text);
            float angle = float.Parse(angleInputTB.Text);
            var insert = ScalingFilter.Process(tmp, w, h);
            int x = Int32.Parse(xInputTB.Text), y = Int32.Parse(yInputTB.Text);
            
            if (angle > 1e-10)
                insert = RotateFilter.Process(insert, angle);
            if (insert.X != x || insert.Y != y)
                insert.ChangeXY(x, y);
            this.Scene.Photos.Insert(0, insert);
            this.Scene.UpdatePhotos();

            Draw();
            ListToComboBox(photoCB, this.Scene.Photos);
        }

        private void RotateBT_Click(object sender, EventArgs e)
        {
            if (photoCB.SelectedIndex == -1)
                return;
            if (!float.TryParse(angleTB.Text, out float angle))
            {
                MessageBox.Show("Wrong angle");
                return;
            }
            var rotate = this.Scene.Photos[photoCB.SelectedIndex];
            this.Scene.Photos.Remove(rotate);
            int x = rotate.X, y = rotate.Y;
            rotate = RotateFilter.Process(rotate, angle);
            if (x != rotate.X || y != rotate.Y)
                rotate.ChangeXY(x, y);
            this.Scene.Photos.Insert(photoCB.SelectedIndex, rotate);

            Draw();
        }

        private void applyBTN_Click(object sender, EventArgs e)
        {
            if (!Int32.TryParse(widthTB.Text, out int w))
            {
                MessageBox.Show("Wrong width");
                return;
            }
            if (!Int32.TryParse(heightTB.Text, out int h))
            {
                MessageBox.Show("Wrong height");
                return;
            }

            this.Scene.Resize(w, h);
            Draw();
        }

        MouseEventArgs e0 = null;
        enum toDo { Move, Resize, Rotate};
        toDo toDoObj;
        private void mainPB_MouseDown(object sender, MouseEventArgs e)
        {
            this.e0 = e;
            if (photoMoveRBTN.Checked && autoChooseCB.Checked)
            {
                int index = this.Scene.GetIndexPhoto(e.X, e.Y);
                if (index != -1)
                    photoCB.SelectedIndex = index;
                if (photoCB.SelectedIndex == -1)
                    return;
                ////if (!showRectCB.Checked)
                //    //toDoObj = toDo.Move;
                ////else
                ////{
                //    //points = this.Scene.Photos[photoCB.SelectedIndex].GetPointsToRect();
                //    /if (Math.Abs(e.X - points[2].X) < 10 && Math.Abs(e.Y - points[2].Y) < 10)
                //        toDoObj = toDo.Resize;
                //    else if (Math.Abs(e.X - points[3].X) < 10 && Math.Abs(e.Y - points[3].Y) < 10)
                //        toDoObj = toDo.Rotate;
                //    else
                //        toDoObj = toDo.Move;
                    
                //}
            }
            else if (moveLightRBT.Checked && autoChooseCB.Checked)
            {
                int index = this.Scene.GetIndexLigh(e.X, e.Y);
                if (index != -1)
                    lightCB.SelectedIndex = index;
            }
        }

        private void mainPB_MouseUp(object sender, MouseEventArgs e)
        {
            this.e0 = null;
        }

        private void mainPB_MouseMove(object sender, MouseEventArgs e)
        {
           // GC.Collect();
            if(this.e0 != null)
            {

                if (photoCB.SelectedIndex != -1 && photoMoveRBTN.Checked)
                {
                    if (toDoObj == toDo.Move)
                        this.Scene.Photos[photoCB.SelectedIndex].Move(e.X - e0.X, e.Y - e0.Y);
                    else if (toDoObj == toDo.Resize) 
                    {
                        this.Scene.Photos[photoCB.SelectedIndex].Process(
                            new ScalingFilter(this.Scene.Photos[photoCB.SelectedIndex].Width + e.X - e0.X,
                            this.Scene.Photos[photoCB.SelectedIndex].Height + e.Y - e0.Y));
                    }
                    else
                    {
                        Vector2 p = Vector2.Normolize(new Vector2(e.X - this.Scene.Photos[photoCB.SelectedIndex].X
                            , e.Y - this.Scene.Photos[photoCB.SelectedIndex].Y));
                        float cosOX = Vector2.DotProduct(p, new Vector2(1, 0));
                        float cosOY = Vector2.DotProduct(p, new Vector2(0, 1));
                        double angle = 0;
                        if (cosOX >= 0 && cosOY >= 0)
                            angle = Math.Acos(cosOX);
                        
                        else if (cosOX <= 0 && cosOY >= 0)
                            angle = Math.Acos(cosOY) + Math.PI / 2;
                        else if (cosOX <= 0 && cosOY <= 0)
                            angle =3*Math.PI/2- Math.Acos(cosOX) + Math.PI / 2;
                        else
                            angle = -Math.Acos(cosOX);
                        //angle = -angle;
                        this.Scene.Photos[photoCB.SelectedIndex].Process(
                            new RotateFilter((float)angle));

                    }
                    this.Scene.UpdatePhotos();
                }
                else if (lightCB.SelectedIndex != -1 && !photoMoveRBTN.Checked)
                {
                    if (this.Scene.Map.Light[lightCB.SelectedIndex] is Spotlight)
                        (this.Scene.Map.Light[lightCB.SelectedIndex] as Spotlight).Move(e.X - e0.X, e.Y - e0.Y);
                    this.Scene.UpdateLightingMap();
                }    
                Draw();
                this.e0 = e;
            }
        }



        private void Draw()
        {
            Bitmap bmp = new Bitmap(Scene.Width, Scene.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.Clear(Color.Black);
            g.DrawImage(Scene.GetBitmap(), 0, 0);
           // if (showRectCB.Checked)
            g0.DrawImage(bmp, 0, 0);
            g.Dispose();
            bmp.Dispose();
            
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Scene = new Scene(500,500);
            paintPanel.Width = 500;
            paintPanel.Height = 500;
            this.g0 = paintPanel.CreateGraphics();
            //this.Scene.Map.AddLight(new Vector3(0, 10, 100), new Vector3(50, 50, 0), 0.5f, new Vector3(Color.Green.R, Color.Green.G, Color.Green.B) / 255);
        }

        private void ListLightToComboBox(List<ILight> lights, ComboBox cb)
        {
            cb.Items.Clear();
            for (int i = 0; i < lights.Count; i++)
                cb.Items.Add(i.ToString());
            cb.SelectedIndex = -1;
        }

        private void AddLightBTN_Click(object sender, EventArgs e)
        {
            if (!Int32.TryParse(xLightTB.Text, out int xPos))
                return;
            if (!Int32.TryParse(yLightTB.Text, out int yPos))
                return;
            if (!Int32.TryParse(zLightTB.Text, out int zPos))
                return;
            if (!Int32.TryParse(xLookToTB.Text, out int xLook))
                return;
            if (!Int32.TryParse(yLookToTB.Text, out int yLook))
                return;
            if (!Double.TryParse(angleLightTB.Text, out double angle))
                return;
            Vector3 color = new Vector3(1, 1, 1);
            if (selectedColor != null)
                color = new Vector3(selectedColor.R, selectedColor.G, selectedColor.B) / 255;

            angle = angle * Math.PI / 180;
            this.Scene.Map.AddLight(new Vector3(xPos, yPos, zPos), new Vector3(xLook, yLook, 0), (float)angle,
                color);
            ListLightToComboBox(this.Scene.Map.Light, lightCB);
            lightCB.SelectedIndex = 0;
            Draw();
        }

        private void selectColorBTN_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() != DialogResult.OK)
                return;
            colorPanel.BackColor = colorDialog1.Color;
            this.selectedColor = colorDialog1.Color;
        }

        private void setBackLightingBTN_Click(object sender, EventArgs e)
        {
            this.Scene.Map.Const = (float)Convert.ToDouble(backLightingNUD.Value);
            this.Scene.UpdateLightingMap();
            Draw();
        }



        private void lightCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lightCB.SelectedIndex == -1)
                return;
            ILight light = this.Scene.Map.Light[lightCB.SelectedIndex];
            if (!(light is Spotlight))
                return;
            xLightTB.Text = light.Position.X.ToString();
            yLightTB.Text = light.Position.Y.ToString();
            zLightTB.Text = light.Position.Z.ToString();
            xLookToTB.Text = (light as Spotlight).Veiw.X.ToString();
            yLookToTB.Text = (light as Spotlight).Veiw.Y.ToString();
            selectedColor = Color.FromArgb(1, (int)(light.Color.X * 255), (int)(light.Color.Y * 255),
                (int)(light.Color.Z * 255));
            colorPanel.BackColor = selectedColor;
        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            if (lightCB.SelectedIndex == -1)
                return;
            this.Scene.Map.Light.RemoveAt(lightCB.SelectedIndex);
            ListLightToComboBox(this.Scene.Map.Light, lightCB);
            this.Scene.UpdateLightingMap();
        }

        private void applyLightBTN_Click(object sender, EventArgs e)
        {
            if (lightCB.SelectedIndex == -1)
                return;
            this.Scene.Map.Light.RemoveAt(lightCB.SelectedIndex);
            AddLightBTN_Click(sender, e);
        }

        private void insertBTN_Click(object sender, EventArgs e)
        {
            if (photoCB.SelectedIndex == -1)
                return;
            if (!Int32.TryParse(insertTb.Text, out int res))
                return;
            if (res < 0) res = 0;
            if (res >= photoCB.Items.Count) res = photoCB.Items.Count - 1;
            Photo p = this.Scene.Photos[photoCB.SelectedIndex];
            this.Scene.Photos.RemoveAt(photoCB.SelectedIndex);
            this.Scene.Photos.Insert(res, p);
            this.Scene.UpdatePhotos();
            Draw();

        }
    }
}
