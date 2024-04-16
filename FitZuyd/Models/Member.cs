using FitZuyd.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitZuyd
{
    public class Member : Person
    {
        public int Progress { get; set; }
        public List<Activity> Activities { get; set; }

        public Member(int id, string name, int age, int progress, string username, string password) : base(name, age, username, password)
        {
            Id = id;
            Name = name;
            Age = age;
            Progress = progress;
            Username = username;
            Password = password;
        }

        public static void CreateMember(int id, string name, int age, int progress, string username, string password)
        {
            DAL DAL = new DAL();
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

        public static void LoginMember(string username, string password) 
        {
            DAL DAL = new DAL();
            Member member = DAL.GetMemberByCredentials(username, password);

            if (member != null)
            {
                MemberMenu memberMenu = new MemberMenu();
                memberMenu.Show();
            }
            else
            {
                MessageBox.Show("Onjuiste gebruikersnaam of wachtwoord. Probeer het opnieuw.", "Login Mislukt", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public void participateSport()
        {
            return;
        }

        public void participateActivity() 
        { 
            return; 
        }

        public void showProgress()
        {
            return;
        }
    }
}
