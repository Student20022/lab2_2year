namespace patternss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SingletonExampleButton_Click(object sender, EventArgs e)
        {
            Singleton singleton1 = Singleton.Instance;
            Singleton singleton2 = Singleton.Instance;

            if (singleton1 == singleton2)
            {
                MessageBox.Show("Singleton.");
            }
        }

        private void AdapterExampleButton_Click(object sender, EventArgs e)
        {
            Target target = new Adapter();
            target.Request();
        }

        private void ObserverExampleButton_Click(object sender, EventArgs e)
        {
            Subject subject = new Subject();
            ConcreteObserver observer1 = new ConcreteObserver("Observer 1", subject);
            ConcreteObserver observer2 = new ConcreteObserver("Observer 2", subject);

            subject.State = 10;
        }
    }
}