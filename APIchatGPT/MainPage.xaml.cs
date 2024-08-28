using OpenAI.Chat;

namespace APIchatGPT
{
    public partial class MainPage : ContentPage
    {

      

        public MainPage()
        {
            InitializeComponent();
           
        }

        private async void OnSendClicked(object sender, EventArgs e)
        {
            var message = QuestionEditor.Text;

            ChatClient client = new(model: "gpt-3.5-turbo-16k", "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");

            ChatCompletion completion = client.CompleteChat(message);

            ResponseLabel.Text = $"[ChatGPT]: {completion}";
        }

    }

}


