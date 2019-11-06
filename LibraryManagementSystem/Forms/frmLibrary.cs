using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LibraryManagementSystem.Forms
{
    public partial class FrmLibrary : Form
    {
        public FrmLibrary()
        {
            InitializeComponent();
        }

        private void FrmLibrary_Load(object sender, EventArgs e)
        {
            LoadBoxes();
        }

        /// <summary>
        /// Clears form and loads list boxes with data.
        /// </summary>
        private void LoadBoxes()
        {
            lstCheckedOut.Items.Clear();
            
            List<Book> checkedBooks =
                LibraryHelper.GetMemberBooks();

            if (checkedBooks != null)
            {
                foreach (Book b in checkedBooks)
                {
                    lstCheckedOut.Items.Add($"{b.ISBN}, " +
                                                $"{b.Title},  " +
                                                $"{b.Author},  " +
                                                $"{b.PubDate},  " +
                                                $"{b.Category}");
                }
            }

            cboBooksAvailable.Items.Clear();

            List<Book> uncheckedBooks =
                LibraryHelper.GetAllUncheckedBooks();

            if (uncheckedBooks != null)
            {
                foreach (Book b in uncheckedBooks)
                {
                    cboBooksAvailable.Items.Add($"{b.ISBN}, " +
                                            $"{b.Title},  " +
                                            $"{b.Author},  " +
                                            $"{b.PubDate},  " +
                                            $"{b.Category}");
                }
            }

            lstSelectBook.Items.Clear();
        }

        private void BtnCheckIn_Click(object sender, EventArgs e)
        {
            List<Book> memberBooks = LibraryHelper.GetMemberBooks();
            
            if (memberBooks != null)
            {
                var selectedItems = lstCheckedOut.SelectedItems;

                List<Book> selectedBooks = GetSelectedItems(
                    selectedItems);

                if (LibraryHelper.CheckInBooks(selectedBooks))
                {
                    MessageBox.Show("Check-In Successful.");

                    LoadBoxes();
                }
                else
                {
                    MessageBox.Show("Nothing selected.");
                }
            }
            else
            {
                MessageBox.Show("Nothing to check-in.");
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var selectedItem = cboBooksAvailable.SelectedItem;

            if (selectedItem != null)
                lstSelectBook.Items.Add(selectedItem);
            else
                MessageBox.Show("Please select an item.");
        }

        private void BtnCheckOut_Click(object sender, EventArgs e)
        {
            if (lstSelectBook.SelectedIndex != -1)
            {
                var selectedItems = lstSelectBook.SelectedItems;

                List<Book> uncheckedBooks =
                    LibraryHelper.GetAllUncheckedBooks();

                List<Book> selectedBooks = GetSelectedItems(
                    selectedItems);

                if (LibraryHelper.CheckoutBooks(selectedBooks))
                {
                    MessageBox.Show("Check-Out Successful.");

                    LoadBoxes();
                }
                else
                {
                    MessageBox.Show("Check-Out Unsuccessful.");
                }
            }
            else
            {
                MessageBox.Show("Nothing selected.");
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private List<Book> GetSelectedItems(ListBox.
            SelectedObjectCollection selectedItems)
        {
            List<string> stringISBNs = new List<string>();
            
            foreach (var item in selectedItems)
            {
                stringISBNs.Add(item.ToString().
                    Substring(0, item.ToString().IndexOf(",")));
            }

            List<Book> selectedBooks =
                LibraryHelper.GetSelectedBooks(stringISBNs);

            return selectedBooks;
        }
    }
}
