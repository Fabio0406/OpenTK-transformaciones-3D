using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1
{
    public class Game : GameWindow
    {
        Escenario escenario;


        //-----------------------------------------------------------------------------------------------------------------
        public Game(int width, int height, string title) : base(width, height, GraphicsMode.Default, title) { }
        
        //-----------------------------------------------------------------------------------------------------------------
        protected override void OnLoad(EventArgs e)
        {
            GL.ClearColor(Color4.Aqua);
            //------------------------------
            this.escenario = new Escenario();
            //Objeto.SerializeJsonFile("cubo.json", GetCuboSimple());
            escenario.SetObjeto("U1", Objeto.DeserializeJsonFile("U.json"));
            escenario.SetObjeto("U2", Objeto.DeserializeJsonFile("U.json"));

            escenario.GetObjeto("U1").SetOrigen(-30, 20, 0);

            this.escenario.GetObjeto("U1").Escalar(2f, 2f, 2f);
            this.escenario.GetObjeto("U2").GetCara("Base").Escalar(1.1f, 1.1f, 1.1f);
            //------------------------------
            base.OnLoad(e);     
        }
        
        //-----------------------------------------------------------------------------------------------------------------
        protected override void OnRenderFrame(FrameEventArgs e)
        {
            //GL.DepthMask(true);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.Enable(EnableCap.DepthTest);
            GL.LoadIdentity();
            //-----------------------
            this.escenario.GetObjeto("U1").Rotar(1,0,0);
            
            this.escenario.GetObjeto("U1").GetCara("BrazoIzquierdo").Rotar(0,1,0);
            //this.escenario.GetObjeto("U2").GetCara("Base").Escalar(1.1f, 1.1f, 1.1f);
            this.escenario.Rotar(0, 1, 0);
            this.escenario.GetObjeto("U1").GetCara("Base").RotarO(1, 0, 0);
            this.escenario.Dibujar();
            //-----------------------
            Context.SwapBuffers();
            base.OnRenderFrame(e);
        }
        //-----------------------------------------------------------------------------------------------------------------
        protected override void OnResize(EventArgs e)
        {
            float d = 50;
            GL.Viewport(0, 0, Width, Height);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Ortho(-d, d, -d, d, -d, d);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();
            base.OnResize(e);
        }
        //-----------------------------------------------------------------------------------------------------------------
        protected override void OnUnload(EventArgs e)
        {
            GL.BindBuffer(BufferTarget.ArrayBuffer, 0);
            base.OnUnload(e);
        }
        //-----------------------------------------------------------------------------------------------------------------
        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            //this.capturarTeclado();
            base.OnUpdateFrame(e);
        }
        /*
        public void capturarTeclado()
        {
            KeyboardState input = Keyboard.GetState();
            if (input.IsKeyDown(Key.Q))
            {
                escenario.Rotar(0.8f, 0, 0);
            }
            if (input.IsKeyDown(Key.W))
            {
                escenario.Rotar(0, 0.8f, 0);
            }
            if (input.IsKeyDown(Key.E))
            {
                escenario.Rotar(0, 0, 0.8f);
            }
            if (input.IsKeyDown(Key.A))
            {
                escenario.Trasladar(-1f, 0, 0);
            }
            if (input.IsKeyDown(Key.S))
            {
                escenario.Trasladar(1f, 0, 0);
            }
            if (input.IsKeyDown(Key.D))
            {
                escenario.Trasladar(0, 1.0f, 0);
            }
            if (input.IsKeyDown(Key.F))
            {
                escenario.Trasladar(0, -1.0f, 0);
            }
            if (input.IsKeyDown(Key.G))
            {
                escenario.Trasladar(0, 0, 1.0f);
            }
            if (input.IsKeyDown(Key.H))
            {
                escenario.Trasladar(0, 0, -1.0f);
            }

            if (input.IsKeyDown(Key.Z))
            {
                escenario.Escalar(0.9f, 0, 0);
            }
            if (input.IsKeyDown(Key.X))
            {
                escenario.Escalar(1.1f, 0, 0);
            }
            if (input.IsKeyDown(Key.C))
            {
                escenario.Escalar(0, 0.9f, 0);
            }
            if (input.IsKeyDown(Key.V))
            {
                escenario.Escalar(0, 1.1f, 0);
            }
            if (input.IsKeyDown(Key.B))
            {
                escenario.Escalar(0, 0, 0.9f);
            }
            if (input.IsKeyDown(Key.N))
            {
                escenario.Escalar(0, 0, 1.1f);
            }

        }*/
    }
}
