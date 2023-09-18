using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Robots_inc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Worker> workers; //אוסף עובדים 
        List<Mission> activeMissions;//אוסף משימות פעילות
        List<RobotSpy> activeRobots; //אוסף רובוטים פעילים

        public MainWindow()
        {
            InitializeComponent();
            workers = getSixWorkers();
            activeRobots = createRobots();
            activeMissions = createMissions();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Have a robotic day (-:","Good bye",MessageBoxButton.OK);
            this.Close();
        }


        //משימה 1
        // : כתבו פעולה המחזירה אוסף של 6 עובדים 
        //מנכ"ל אחד, 2 מנהלי תפעול ו-3 עובדי תפעול
        //כתבו זימון לפעולה שכתבתם בפעולה הבונה של החלון
        public List<Worker> getSixWorkers()
        {
            List<Worker> Cworkers = new List<Worker>();
            Cworkers.Add(new OperationalWorker("peasentIII", "6", DateTime.Now, "1234567", 70, 72));
            Cworkers.Add(new OperationalWorker("peasentII", "5", DateTime.Now, "123456", 70, 65));
            Cworkers.Add(new OperationalWorker("peasent", "4", DateTime.Now, "12345", 70, 70));
            Cworkers.Add(new OperationManager("mr.managerII", "3", DateTime.Now, "1234567890manager", 150, 70, 25));
            Cworkers.Add(new OperationManager("mr.manager", "2", DateTime.Now, "1234567890managerII", 150, 65, 28));
            Cworkers.Add(new GeneralManager("mr.ceo", "1", DateTime.Now, "1234567890ceo", 90000.8, false));
            return Cworkers;
        }

        //משימה 2
        //כתבו פעולה המחזירה אוסף של 8 רובוטים
        //כתבו זימון לפעולה שכתבתם בפעולה הבונה של החלון
        public List<RobotSpy> createRobots()
        {
            List<RobotSpy> robots = new List<RobotSpy>()
            {
                new RobotFly(),
                new RobotFly(),
                new RobotQuad(),
                new RobotQuad(),
                new RobotQuad(),
                new RobotWheels(),
                new RobotWheels(),
                new RobotWheels()
            };
            return robots;
        }
        //משימה 3
        //כתבו פעולה המחזירה אוסף של 5 משימות
        //כתבו זימון לפעולה שכתבתם בפעולה הבונה של החלון
        public List<Mission> createMissions()
        {
            List<Mission> missions = new List<Mission>()
            {
                new Mission(RandomDate(), "random1"),
                new Mission(RandomDate(), "random2"),
                new Mission(RandomDate(), "random3"),
                new Mission(RandomDate(), "random4"),
                new Mission(RandomDate(), "random5")
            };
            return missions;
        }
        public static DateTime RandomDate()
        {
            DateTime start = DateTime.Now;
            Random rnd = new Random();
            int range = 3650;
            int addDays = rnd.Next(1, range);
            start.AddDays(addDays);
            return start;

        }
        //משימה 4
        //login כתבו פעולה המגיבה לללחיצה על כפתור 
        //אם הפרטים לא תואמים לעובד הקיים באוסף העובדים - תוצג הודעה מתאימה
        //WndMain אם כן, יש ליצור מופע של חלון 
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            bool foundWorker = false;
            Worker worker = null;
            //...אם מספר הזיהוי והסיסמה תואמים לעובד ברשימה, אז
            foreach (Worker currWorker in workers)
            {
                if(currWorker.GetIdNumber() == tbxID.Text && currWorker.GetPassword() == tbxPassword.Password)
                {
                    foundWorker = true;
                    worker = currWorker;
                }
            }
            if (foundWorker)
            {
                WndMain main = new WndMain(worker, activeMissions, activeRobots, workers);
                main.ShowDialog();
            }
            else
            {
                MessageBox.Show("id or password not correct!", "error finding user", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
    }
}
