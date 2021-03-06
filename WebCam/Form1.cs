﻿using System;
using System.Drawing;
using System.Windows.Forms;


namespace WebCam
{
    public partial class Form1 : Form
    {
        public DirectX.Capture.Filter Camera;
        public DirectX.Capture.Capture CaptureInfo;
        public DirectX.Capture.Filters CamContainer;
        Image capturaImagem;

        //Window Size
        float width = 320;
        float height = 240;
        Size windowSize;
        bool wide = false;

        //Movimento de tela
        private bool mouseDown;
        private Point lastLocation;

        public Form1()
        {
            InitializeComponent();
            this.MouseWheel += Zoom;
        }

        private void Zoom(object sender, MouseEventArgs e)
        {
            //Se tiver valor de captura de camera
            if (capturaImagem != null) { 
                int w = 4;
                int h = 3;
                if (wide)
                {
                    w = 16;
                    h = 9;
                }

                if(e.Delta > 0)
                {
                    width += w;
                    height += h;
                    Posicao(w, h);
                }
                else
                {
                    width -= w;
                    height -= h;
                    Posicao(-w, -h);
                }
                Resize();
            }
        }

        public void Posicao(int w = -1, int h = -1)
        {
            if (w == -1 || h == -1)
            {
                this.StartPosition = FormStartPosition.Manual;
                foreach (var scrn in Screen.AllScreens)
                {
                    if (scrn.Bounds.Contains(this.Location))
                    {
                        this.Location = new Point(scrn.Bounds.Right - this.Width - 10, scrn.Bounds.Bottom - this.Height - 10);
                        return;
                    }
                }
            }
            else
            {
                this.Location = new Point(this.Location.X - w, this.Location.Y - h);
            }
        }

        public void RemoveTitulos()
        {
            //Coloca por cima da tela
            this.TopMost = true;

            //Remove Title Bar
            this.ControlBox = false;
            this.Text = String.Empty;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        public void AtualizaImagem(PictureBox frame)
        {
            try
            {
                capturaImagem = frame.Image;
                this.picWebCam.Image = capturaImagem;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message);
            }
        }

        public void AtivaCamera(int index)
        {
            try
            {
                //Obtém o dispositivo de entrada do vídeo
                Camera = CamContainer.VideoInputDevices[index];
                //Inicializa a Captura usando o dispositivo
                CaptureInfo = new DirectX.Capture.Capture(Camera, null);
                //Define a janela de visualização do vídeo
                CaptureInfo.PreviewWindow = this.picWebCam;
                //Capturando o tratamento de evento
                CaptureInfo.FrameCaptureComplete += AtualizaImagem;
                //Captura o frame do dispositivo
                CaptureInfo.CaptureFrame();

                //Função de movimentação
                this.pbxMove.Visible = true;
                this.pbxMove.MouseDown += MouseDown;
                this.pbxMove.MouseMove += MouseMove;
                this.pbxMove.MouseUp += MouseUp;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Cria o filtro da camera
            CamContainer = new DirectX.Capture.Filters();

            try
            {
                int no_of_cam = CamContainer.VideoInputDevices.Count;
                for (int i = 0; i < no_of_cam; i++)
                {
                    cbxCamera.Items.Add(CamContainer.VideoInputDevices[i].Name);
                }
                cbxCamera.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message);
            }
        }

        private void Resize()
        {
            windowSize = new Size((int)width - 1, (int)height);

            this.Size = windowSize;
            picWebCam.Size = new Size((int)width, (int)height);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cbxCamera.Visible = false;
            cbxWide.Visible = false;
            button1.Visible = false;
            
            //Remove titulo da Janela
            RemoveTitulos();

            //Verifica se está em Wide
            if (cbxWide.Checked)
            {
                wide = true;
                width = 427;
                height = 240;
            }
            //Redimenciona a tela
            Resize();

            //Ativa a camera Selecionada
            AtivaCamera(cbxCamera.SelectedIndex);

            //Altera a posição da janela
            Posicao();
        }

        private void MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void pbxMove_MouseHover(object sender, EventArgs e)
        {
            this.pbxMove.Size = new Size(20,20);
        }

        private void pbxMove_MouseLeave(object sender, EventArgs e)
        {
            this.pbxMove.Size = new Size(4, 4);
        }
    }
}
