using System;
using System.Windows;

namespace School
{
    /// <summary>
    /// Interaction logic for StudentForm.xaml
    /// </summary>
    public partial class StudentForm : Window
    {
        #region Predefined code

        public StudentForm()
        {
            InitializeComponent();
        }

        #endregion

        // If the user clicks OK to save the Student details, validate the information that the user has provided
        private void ok_Click(object sender, RoutedEventArgs e)
        {
            if (firstName.Text == "")
            {
                MessageBox.Show("A student must have a first name.", "Error",MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (string.IsNullOrEmpty(this.lastName.Text))
            {
                MessageBox.Show("A student must have a last name.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (string.IsNullOrEmpty(this.dateOfBirth.Text))
            {
                MessageBox.Show("Please enter a date of birth.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            DateTime age;
            if (!DateTime.TryParse(this.dateOfBirth.Text, out age))
            {
                MessageBox.Show("Please enter a valid date of birth dd/mm/y", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            TimeSpan difference = DateTime.Now.Subtract(age);
            int theAge = (int)(difference.Days / 365.25);
            if (theAge <= 5)
            {
                MessageBox.Show("The student has to be atleast 5 years old.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            // TODO: Exercise 2: Task 2a: Check that the user has provided a first name
            // TODO: Exercise 2: Task 2b: Check that the user has provided a last name
            // TODO: Exercise 2: Task 3a: Check that the user has entered a valid date for the date of birth
            // TODO: Exercise 2: Task 3b: Verify that the student is at least 5 years old

            // Indicate that the data is valid
            this.DialogResult = true;
        }
    }
}
