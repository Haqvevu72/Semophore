using System.Collections.ObjectModel;

namespace Semophore
{
    public partial class Form1 : Form
    {
        int thread_No = 0;
        public ObservableCollection<Thread> Created_List = new ObservableCollection<Thread>();
        public ObservableCollection<string> Created_Names = new ObservableCollection<string>();

        public ObservableCollection<Thread> Waiting_List = new ObservableCollection<Thread>();
        public ObservableCollection<string> Waiting_Names = new ObservableCollection<string>();

        public ObservableCollection<Thread> Working_List = new ObservableCollection<Thread>();
        public ObservableCollection<string> Working_Names = new ObservableCollection<string>();

        SemaphoreSlim semaphoreSlim = new SemaphoreSlim(0, 6);
        public Form1()
        {
            InitializeComponent();
            Created_Threads.DataSource = Created_List;
        }

        private void Create_Button_Click(object sender, EventArgs e)
        {
            Thread new_thread = new Thread(DoSomething);
            new_thread.Name = $"Thread {thread_No}";
            thread_No++;

            Created_List.Add(new_thread);
            Created_Names.Add(new_thread.Name);

            Created_Threads.DataSource = null;
            Created_Threads.DataSource = Created_Names;
        }


        private void Waiting_Threads_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string selected_item = Waiting_Threads.SelectedItem.ToString();
            Waiting_Names.Remove(selected_item);
            Waiting_Threads.DataSource = null;
            Waiting_Threads.DataSource = Waiting_Names;

            for (int i = 0; i < Waiting_List.Count; i++)
            {
                if (Waiting_List[i].Name == selected_item)
                {
                    Waiting_List.RemoveAt(i);
                    break;
                }
            }
        }


        private async void Created_Threads_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string selected_item = Created_Threads.SelectedItem.ToString();

            Created_Names.Remove(selected_item);
            Created_Threads.DataSource = null;
            Created_Threads.DataSource = Created_Names;


            Thread toWait = null;
            for (int i = 0; i < Created_List.Count; i++)
            {
                if (Created_List[i].Name == selected_item)
                {
                    toWait = Created_List[i];
                    Created_List.Remove(toWait);
                    Waiting_List.Add(toWait);
                    Waiting_Names.Add(toWait.Name);

                    Waiting_Threads.DataSource = null;
                    Waiting_Threads.DataSource = Waiting_Names;
                    break;
                }
            }

            await Task.Delay(5000);
            for (int i = 0; i < Waiting_List.Count; i++)
            {
                Waiting_List[i].Start();
                Waiting_Names.Remove(Waiting_List[i].Name);
                Working_Names.Add(Waiting_List[i].Name);
                Working_List.Add(Waiting_List[i]);
                Waiting_List.Remove(Waiting_List[i]);

                Working_Threads.DataSource = null;
                Working_Threads.DataSource = Working_Names;

                Waiting_Threads.DataSource = null;
                Waiting_Threads.DataSource = Waiting_Names;
            }

               await Task.Delay(1000);
                for (int i = 0; i < Working_List.Count; i++)
                {

                        Working_Names.Remove(Working_List[i].Name);
                        Working_Threads.DataSource = null;
                        Working_Threads.DataSource = Working_Names;

                        Working_List.RemoveAt(i);
                }
            

        }

        private void DoSomething(object? parameter)
        {
            semaphoreSlim.Wait();
            Console.WriteLine("I am doing something");
            semaphoreSlim.Release();
        }
    }
}