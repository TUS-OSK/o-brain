using System.Speech.Recognition;
using System.Windows.Controls;
using SpeechLib;

namespace o_brain_app.View
{
    /// <summary>
    /// TopPage.xaml の相互作用ロジック
    /// </summary>
    public partial class TopPage : Page
    {
        private SpeechRecognizer _reco = new SpeechRecognizer();
        public TopPage()
        {
            InitializeComponent();
            _reco.LoadGrammar(new DictationGrammar());
            _reco.SpeechRecognized += (s, e) =>
            {
                Block.Text += e.Result.Text;
            };
        }

    }
}
