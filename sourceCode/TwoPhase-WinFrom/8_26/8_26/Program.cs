namespace _8_26
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new Form1());     //轮播图
            //Application.Run(new LikeLink());  //下划线模拟链接
            //Application.Run(new FocusNotLost());  //丢失光标时内容校验            
            //Application.Run(new MouseMove());  //鼠标组件内移动
            //Application.Run(new ComboBoxOpen());  //comboBoxOpen
            //Application.Run(new FocusIsNull());  //comboBoxOpen
            //Application.Run(new Enter());  //comboBoxOpen
            //Application.Run(new Esc());  //comboBoxOpen
            Application.Run(new KeyMove());  //comboBoxOpen
        }
    }
}