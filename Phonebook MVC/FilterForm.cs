using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Phonebook_MVC
{
    public partial class FilterForm : Form
    {
        private List<Person> persons;
        private FilterType type;

        public FilterForm(List<Person> persons, FilterType type)
        {
            
            InitializeComponent();

            switch (type)
            {
                case FilterType.ByName:
                    Text += "имени";
                    lbHint.Text = "Подстрока для имени";
                    break;
                case FilterType.ByPhoneNumber:
                    break;
                case FilterType.ByBirthMonth:
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }

            this.persons = persons;
            this.type = type;
            dgvResult.DataSource = persons;
        }

        private void btFilter_Click(object sender, EventArgs e)
        {
            switch (type)
            {
                case FilterType.ByName:
                    dgvResult.DataSource = (from person in persons 
                        where person.Name.Contains(tbFilterValue.Text) 
                        select person).ToList();
                    break;
                case FilterType.ByPhoneNumber:
                    break;
                case FilterType.ByBirthMonth:
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
        }
    }
}