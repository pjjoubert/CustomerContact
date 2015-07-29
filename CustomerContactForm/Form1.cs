using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CustomerContactForm
{
    public partial class Form1 : Form
    {
        private List<Classes.CustomerContact> contactList;
        private int currentContactIndex;
        private int currentCustomerID;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            contactList = new List<Classes.CustomerContact>();
            currentContactIndex = 0;
            RefreshCustomerDatasource();
        }

        private void RefreshCustomerDatasource()
        {
            try
            {
                using (var context = new Classes.CustomerContext())
                {
                    List<string> result = (from a in context.Customers orderby a.Name select a.Name).ToList();
                    cbCustomers.DataSource = result;
                    cbCustomers.Refresh();
                }
            }
            catch (Exception ex)
            {
                //log error
            }
        }

        private void btnAddNewCust_Click(object sender, EventArgs e)
        {
            currentCustomerID = -1; //set customer ID to -1 to indicate new customer
            clearContacts();
            txbCustID.Text = "";
            txbCustName.Text = "";
            txbLat.Text = "";
            txbLong.Text = "";

            txbCustName.Focus();
        }

        private void clearContacts()
        {
            contactList.Clear();
            txbCustContName.Text = "";
            txbCustContEmail.Text = "";
            txbCustContNum.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //if new button is clicked, set current customer id to -1
            //if currentCustomerID != -1 do Update
            //else
            //Handle as new

            if (currentCustomerID == -1)
            {
                #region NewCustomer
                Classes.Customer customer = new Classes.Customer();
                if (txbCustName.Text.Trim() == "")
                {
                    //do nothing

                }
                else
                {
                    customer.Name = txbCustName.Text;

                    decimal convert = 0;
                    if (decimal.TryParse(txbLat.Text, out convert))
                    {
                        customer.Latitude = convert;
                    }
                    else
                    {
                        customer.Latitude = 0;
                    }

                    if (decimal.TryParse(txbLong.Text, out convert))
                    {
                        customer.Longitude = convert;
                    }
                    else
                    {
                        customer.Longitude = 0;
                    }
                    try
                    {
                        using (var context = new Classes.CustomerContext())
                        {
                            context.Customers.Add(customer);
                            context.SaveChanges();
                            txbCustID.Text = customer.ID.ToString();
                            currentCustomerID = customer.ID;
                        }
                    }
                    catch (Exception ex)
                    {
                        //log error
                    }
                }
                #endregion
            }
            else
            {
                #region UpdateCustomer
                if (txbCustName.Text.Trim() == "")
                {
                }
                else
                {
                    try
                    {
                        using (var context = new Classes.CustomerContext())
                        {
                            var result = (from a in context.Customers where a.ID == currentCustomerID select a).FirstOrDefault();
                            if (result != null)
                            {
                                result.Name = txbCustName.Text;
                                decimal tempValue;
                                result.Latitude = decimal.TryParse(txbLat.Text, out tempValue) ? tempValue : 0;
                                result.Longitude = decimal.TryParse(txbLong.Text, out tempValue) ? tempValue : 0;

                                context.SaveChanges();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        //log error
                    }
                }
                #endregion
            }

            RefreshCustomerDatasource();

        }

        private void cbCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                contactList.Clear();

                using (var context = new Classes.CustomerContext())
                {
                    var custResult = (from a in context.Customers where a.Name == cbCustomers.SelectedItem.ToString() select a).FirstOrDefault();

                    if (custResult != null)
                    {
                        txbCustID.Text = custResult.ID.ToString();
                        txbCustName.Text = custResult.Name;
                        txbLat.Text = custResult.Latitude.ToString();
                        txbLong.Text = custResult.Longitude.ToString();

                        currentCustomerID = custResult.ID;
                    }

                    UpdateContacts(custResult.ID);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void UpdateContacts(int customerID)
        {
            using (var context = new Classes.CustomerContext())
            {
                var contactResults = (from b in context.CustomerContacts where b.CustomerID == customerID select b).ToList();
                if (contactResults.Count != 0)
                {
                    contactList = contactResults;
                    currentContactIndex = 0;

                    lblContactCount.Text = (currentContactIndex + 1).ToString();
                    lblContactTotal.Text = " of " + contactList.Count().ToString();
                    txbCustContName.Text = contactList[0].Name;
                    txbCustContEmail.Text = contactList[0].Email;
                    txbCustContNum.Text = contactList[0].ContactNumber.ToString();
                }
                else
                {
                    lblContactCount.Text = "1";
                    lblContactTotal.Text = " of " + contactList.Count().ToString();

                    txbCustContName.Text = "";
                    txbCustContEmail.Text = "";
                    txbCustContNum.Text = "";

                    txbCustContName.Focus();
                }
            }
        }

        private void btnNewContact_Click(object sender, EventArgs e)
        {
            txbCustContName.Text = "";
            txbCustContEmail.Text = "";
            txbCustContNum.Text = "";

            txbCustContName.Focus();
            currentContactIndex = -1;
        }

        #region contactNavigationButtons
        private void btnFirst_Click(object sender, EventArgs e)
        {
            currentContactIndex = 0;
            lblContactCount.Text = (currentContactIndex + 1).ToString();
            txbCustContName.Text = contactList[0].Name;
            txbCustContEmail.Text = contactList[0].Email;
            txbCustContNum.Text = contactList[0].ContactNumber.ToString();
        }

        private void btnBackOne_Click(object sender, EventArgs e)
        {
            if (currentContactIndex - 1 >= 0)
            {
                currentContactIndex--;
                lblContactCount.Text = (currentContactIndex + 1).ToString();
                txbCustContName.Text = contactList[currentContactIndex].Name;
                txbCustContEmail.Text = contactList[currentContactIndex].Email;
                txbCustContNum.Text = contactList[currentContactIndex].ContactNumber.ToString();
            }
        }

        private void btnForwardOne_Click(object sender, EventArgs e)
        {
            if (currentContactIndex + 1 <= (contactList.Count - 1))
            {
                currentContactIndex++;
                lblContactCount.Text = (currentContactIndex + 1).ToString();
                txbCustContName.Text = contactList[currentContactIndex].Name;
                txbCustContEmail.Text = contactList[currentContactIndex].Email;
                txbCustContNum.Text = contactList[currentContactIndex].ContactNumber.ToString();
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            currentContactIndex = contactList.Count - 1;
            lblContactCount.Text = (currentContactIndex + 1).ToString();
            txbCustContName.Text = contactList[(contactList.Count - 1)].Name;
            txbCustContEmail.Text = contactList[(contactList.Count - 1)].Email;
            txbCustContNum.Text = contactList[(contactList.Count - 1)].ContactNumber.ToString();
        }
        #endregion

        private void btnSaveContact_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentContactIndex == -1) //new button has been clicked
                {
                    if ((txbCustContNum.Text != "") || (txbCustContEmail.Text != ""))
                    {
                        Classes.CustomerContact newContact = new Classes.CustomerContact();
                        newContact.CustomerID = currentCustomerID;
                        newContact.Name = txbCustContName.Text;
                        newContact.Email = txbCustContEmail.Text;
                        int contactNumber;
                        if (int.TryParse(txbCustContNum.Text, out contactNumber))
                        {
                            newContact.ContactNumber = contactNumber;
                        }
                        using (var context = new Classes.CustomerContext())
                        {
                            context.CustomerContacts.Add(newContact);
                            context.SaveChanges();
                            currentContactIndex = newContact.ID;
                        }
                        UpdateContacts(currentCustomerID);
                    }
                    else
                    {
                        //empty fields. HAndle error and ignore save
                    }

                }
                else
                {
                    using (var context = new Classes.CustomerContext())
                    {
                        Classes.CustomerContact update = contactList[currentContactIndex];
                        update.Name = txbCustContName.Text;
                        update.Email = txbCustContEmail.Text;
                        int tempVal = 0;
                        update.ContactNumber = int.TryParse(txbCustContNum.Text, out tempVal) ? tempVal : 0;
                    }
                }
            }
            catch (Exception ex)
            {
                //log error
            }
        }

        private void btnCustDelete_Click(object sender, EventArgs e)
        {
            try
            {

                //delete customer
                using (var context = new Classes.CustomerContext())
                {
                    //delete customer contacts
                    var contactResult = (from a in context.CustomerContacts where a.CustomerID == currentCustomerID select a).ToList();
                    foreach (var item in contactResult)
                    {
                        context.CustomerContacts.Remove(item);
                        context.SaveChanges();
                    }

                    var result = (from a in context.Customers where a.ID == currentCustomerID select a).FirstOrDefault();
                    context.Customers.Remove(result);
                    context.SaveChanges();
                }
                //refresh the combobox
                RefreshCustomerDatasource();
            }
            catch (Exception ex)
            {
                //log error
            }
        }

        private void btnContDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new Classes.CustomerContext())
                {
                    Classes.CustomerContact deleted = contactList[currentContactIndex];
                    var result = (from a in context.CustomerContacts where a.ID ==deleted.ID select a).FirstOrDefault();
                    
                    context.CustomerContacts.Remove(result);
                    context.SaveChanges();
                }
                UpdateContacts(currentCustomerID);
            }
            catch (Exception ex)
            {
                //log error
            }
        }


    }
}
