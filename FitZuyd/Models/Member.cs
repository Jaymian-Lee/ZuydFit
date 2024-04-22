using FitZuyd.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitZuyd
{
    public class Member : Person
    {
        public int Progress { get; set; }
        public List<Activity> Activities { get; set; } = new List<Activity>();
        public static List<Activity> ParticipatedActivities { get; set; } = new List<Activity>();

        // Lege constructor voor het aanmaken van een nieuw Member object
        public Member() : base("", 0, "", "")
        {
            ParticipatedActivities = new List<Activity>(); // Zorg dat deze lijst geïnitialiseerd is
        }

        // Constructor voor het aanmaken van een nieuw Member object
        public Member(int id, string name, int age, int progress, string username, string password) : base(name, age, username, password)
        {
            Id = id;
            Name = name;
            Age = age;
            Progress = progress;
            Username = username;
            Password = password;
            ParticipatedActivities = new List<Activity>();
        }

        public void AddActivity(Activity activity)
        {
            ParticipatedActivities.Add(activity);
        }

        // Methode om een nieuw Member object aan te maken en toe te voegen aan de database
        public static void CreateMember(int id, string name, int age, int progress, string username, string password)
        {
            DAL DAL = new DAL(); // Assuming you have implemented the DAL class
            try
            {
                Member newMember = new Member(id, name, age, progress, username, password);
                DAL.AddMember(newMember);
                MessageBox.Show("Member geregistreerd!");
                MemberMenu memberMenu = new MemberMenu();
                memberMenu.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fout bij het registreren van de member: " + ex.Message);
            }
        }

        // Methode om een Member in te loggen
        public static void LoginMember(string username, string password)
        {
            DAL DAL = new DAL(); // Assuming you have implemented the DAL class
            Member member = DAL.GetMemberByCredentials(username, password);

            if (member != null)
            {
                MemberMenu memberMenu = new MemberMenu();
                memberMenu.Show();
            }
            else
            {
                MemberLogin memberLogin = new MemberLogin();
                memberLogin.Show();
                MessageBox.Show("Onjuiste gebruikersnaam of wachtwoord. Probeer het opnieuw.", "Login Mislukt", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Methode om alle Members op te halen uit de database
        public DataTable GetAllMembers()
        {
            DAL dal = new DAL(); // Assuming you have implemented the DAL class
            return dal.GetAllMembers();
        }

        // Methode om deel te nemen aan een sport
        public void participateSport()
        {
            // Implement logic to handle sport participation
            // This could involve updating progress points, adding a sport activity to the participated activities list, etc.
            MessageBox.Show("Deelgenomen aan een sport!");
        }

        // Methode om deel te nemen aan een activiteit
        public void participateActivity()
        {
            // Implement logic to handle activity participation
            // This could involve updating progress points, adding an activity to the participated activities list, etc.
            MessageBox.Show("Deelgenomen aan een activiteit!");
        }

        // Methode om de voortgang weer te geven
        public void showProgress()
        {
            // Implement logic to display the member's progress
            // This could involve showing a progress bar, displaying a percentage, or providing other visual feedback
            MessageBox.Show("Uw voortgang: " + Progress);
        }
    }
}
