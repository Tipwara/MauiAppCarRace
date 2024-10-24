
using MauiAppCSharpBasic.Classes;

namespace MauiAppCSharpBasic
{
    public partial class MainPage : ContentPage
    {
        Car audi;

        Car nissan;

        bool isFinish = false;
        public MainPage()
        {
            InitializeComponent();

            audi = new Car("A1", 220, 20);
            audi.UseFuelRate = 10; //ไม่กำหนดค่าผ่าน constructure
            nissan = new Car("S1", 180, 4);
            nissan.UseFuelRate = 8;

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (!this.isFinish)
            {
                var screenWidth = Application.Current.MainPage.Width;
                this.AudiRun(screenWidth);
                this.NissanRun(screenWidth);
                this.myLabel.Text = audi.ShowResult+"\n" + nissan.ShowResult();
                this.isFinish = true;
            }
            else
            {
                ImageCar1.TranslateTo(0, 0, 0, Easing.Linear);
                ImageCar2.TranslateTo(0, 0, 0, Easing.Linear);
                this.isFinish = true;
            }

            /*ส่ง paremeter ให้ class car ใน Car.cs
            Car audi = new Car("A1",220, 50); //สร้าง objrct audi กับ nissanโดยใช้ สิ่งที่อยู่ใน class
            Car nissan = new Car("S1", 180, 60);

            audi.CarCalculator(300, 40);
            nissan.CarCalculator(30, 50);*/

            //myLabel.Text = audi.ShowResult() + nissan.ShowResult();
        }
        private void AudiRun(double distance)
        {
            var timeuse = audi.TimeUseForRun(distance);
            ImageCar1.TranslateTo(distance - 100, 0, timeuse * 1000, Easing.Linear);

        }
        private void NissanRun(double distance)
        {
            var timeuse = nissan.TimeUseForRun(distance);
            ImageCar2.TranslateTo(distance - 100, 0, timeuse*1000, Easing.Linear);

        }
    }

}
