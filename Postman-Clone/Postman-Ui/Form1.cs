using Postman_Library;

namespace Postman_Ui
{
    public partial class Form1 : Form
    {
        private readonly IApiAccess _apiAccess = new ApiAccess();

        public Form1()
        {
            InitializeComponent();
            apiBar.Minimum = 0;
            apiBar.Maximum = 100;
            apiBar.Step = 1;
            apiBar.Value = 0;
        }

        private async void callApi_Click(object sender, EventArgs e)
        {
            systemStatus.Text = "Api istek Gönderiliyor";
            resultText.Text = "";
            apiBar.Value = 0;

            if (_apiAccess.IsValidUrl(apiText.Text) == false)
            {
                systemStatus.Text = "Geçersiz Url.!";
                return;
            }

            try
            {
                var progressTask = Task.Run(() =>
                {
                    for (int i = 0; i <= 100; i++)
                    {                    
                        Invoke(new Action(() =>
                        {
                            apiBar.Value = i;
                        }));
                        Task.Delay(30).Wait();
                    }
                });

                await progressTask;
                resultText.Text = await _apiAccess.CallApiAsync(apiText.Text);       
                systemStatus.Text = "Hazýr";
            }
            catch (Exception ex)
            {
                resultText.Text = $"Hata: {ex.Message}";
                systemStatus.Text = "Hata";
            }
        }
    }
}
