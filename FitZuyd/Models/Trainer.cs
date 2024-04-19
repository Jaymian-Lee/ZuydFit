<<<<<<< HEAD
﻿using FitZuyd.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitZuyd
{
    public class Trainer : Person
    {

        public List<Activity> Activities { get; set; }
        public List<Location> Locations { get; set; }

        public Trainer(int id, string name, int age,string username, string password) : base(name, age, username, password)
        {
            Id = id;
            Name = name;
            Age = age;
            Username = username;
            Password = password;
        }
=======
﻿using FitZuyd.Forms;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Runtime.InteropServices;

namespace FitZuyd
{
    public class Trainer : Person
    {

        public List<Activity> Activities { get; set; }
        public List<Location> Locations { get; set; }

        public Trainer(int id, string name, int age, string username, string password) : base(name, age, username, password)
        {
            Id = id;
            Name = name;
            Age = age;
            Username = username;
            Password = password;
        }

>>>>>>> e239ee287ce2435f78d8e0aa3f0a677b67e516f8
        public static void CreateTrainer(int id, string name, int age, string username, string password)
        {
            // Creëer een nieuw Trainer object
            Trainer nieuweTrainer = new Trainer(0, name, age, username, password);

            // Voeg de nieuwe trainer toe aan de database
            DAL DAL = new DAL();
            try
            {
                DAL.AddTrainer(nieuweTrainer);
                MessageBox.Show("Trainer geregistreerd!");
                TrainerMenu trainerMenu = new TrainerMenu();
                trainerMenu.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fout bij het registreren van de trainer: " + ex.Message);
            }
        }

        public static void LoginTrainer(string username, string password)
        {
            // Maak een instantie van DAL en roep de nieuwe methode aan
            DAL DAL = new DAL();
            Trainer trainer = DAL.GetTrainerByCredentials(username, password);

            if (trainer != null)
            {
                // Inloggen geslaagd, open het TrainerMenu
                TrainerMenu trainerMenu = new TrainerMenu();
                trainerMenu.Show();
            }
            else
            {
                // Inloggen mislukt, toon een foutbericht
                MessageBox.Show("Onjuiste gebruikersnaam of wachtwoord. Probeer het opnieuw.", "Login Mislukt", MessageBoxButtons.OK, MessageBoxIcon.Error);
<<<<<<< HEAD
            }
        }

        public void addLocation() 
        {
            return;
        }

=======
                TrainerLogin trainerLogin = new TrainerLogin();
                trainerLogin.Show();
            }
        }

        public void addLocation() 
        {
            return;
        }

>>>>>>> e239ee287ce2435f78d8e0aa3f0a677b67e516f8
        public void addActivity()
        {
            return;
        }

    }
}
