using FitZuyd.Forms;
using FitZuyd;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Xml.Linq;
using System;

public class Member : Person
{
    public int Progress { get; set; }
    public List<Activity> Activities { get; set; } = new List<Activity>();
    public List<Activity> ParticipatedActivities { get; set; } = new List<Activity>();
    public static Member CurrentMember { get; set; } // static reference to the current logged-in member

    // Default constructor initializing ParticipatedActivities
    public Member() : base("", 0, "", "")
    {
        ParticipatedActivities = new List<Activity>();
    }

    // Parameterized constructor to initialize a Member object
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

    // Method to add an activity to the ParticipatedActivities list
    public void AddActivity(Activity activity)
    {
        ParticipatedActivities.Add(activity);
    }

    // Static method to create a new member and save it to the database
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

    // Static method to login a member using their credentials
    public static bool LoginMember(string username, string password)
    {
        DAL DAL = new DAL();
        Member member = DAL.GetMemberByCredentials(username, password);

        if (member != null)
        {
            CurrentMember = member;
            MessageBox.Show("Succesvol ingelogd!");
            MemberMenu memberMenu = new MemberMenu();
            memberMenu.Show();
            return true;
        }
        else
        {
            CurrentMember = null;
            return false;
        }
    }

    // Method to retrieve all members from the database
    public DataTable GetAllMembers()
    {
        DAL dal = new DAL();
        return dal.GetAllMembers();
    }

    // Method to indicate participation in a sport
    public void participateSport()
    {
        MessageBox.Show("Deelgenomen aan een sport!");
    }

    // Method to indicate participation in an activity
    public void participateActivity()
    {
        MessageBox.Show("Deelgenomen aan een activiteit!");
    }

    // Method to show the progress of the member
    public void showProgress()
    {
        MessageBox.Show("Uw voortgang: " + Progress);
    }

    // Method to update the progress of the member, ensuring it does not exceed 100
    public void UpdateProgress(int points)
    {
        Progress += points;
        if (Progress > 100) Progress = 100;
    }
}
