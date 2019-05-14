using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phonebook_MVC
{
    public partial class PhonebookForm : Form
    {
        private String filePath = Directory.GetCurrentDirectory() + @"\phonebook.xml";
        
        private DataTable _personsTable;

        private List<Person> Persons =>
            (from person in _personsTable.AsEnumerable()
                select new Person
                {
                    Id = int.Parse(person.Field<string>("id")),
                    Name = person.Field<string>("name"),
                    Phone = person.Field<string>("phone"),
                    Birthday = person.Field<string>("birthday")
                }).ToList();

        public PhonebookForm()
        {
            InitializeComponent();
        }

        private void PhonebookForm_Load(object sender, EventArgs e)
        {
            // Загрузить телефонную книгу из XML
            using (var streamReader = new StreamReader(filePath))
            {
                var dataset = new DataSet();
                dataset.ReadXml(streamReader, XmlReadMode.Auto);
                _personsTable = dataset.Tables[0];
            }

            dgvPhonebook.DataSource = _personsTable;
        }

        private void PhonebookForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Выгрузить телефонную книгу в XML
            _personsTable.WriteXml(filePath, XmlWriteMode.WriteSchema);
        }

        private void btFilterName_Click(object sender, EventArgs e)
        {
            new FilterForm(Persons, FilterType.ByName).ShowDialog();
        }

        private void btFilterPhoneNumber_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void btFilterBirthMonth_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}