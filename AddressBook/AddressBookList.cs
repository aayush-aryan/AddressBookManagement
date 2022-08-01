using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AddressBook
{
    class AddressBookList
    {
        List<Contact> addresslist = new List<Contact>();
        Dictionary<string, List<Contact>> dict = new Dictionary<string, List<Contact>>(); // uc5 for adding Multiple person, one at a time
        /// <summary>
        /// method for add contact in list
        /// </summary>
        /// <param name="contact"></param>
        public void Addcontact(Contact contact)
        {
            addresslist.Add(contact);
        }
        /// <summary>
        /// method for Updating personList
        /// </summary>
        /// <param name="name"></param>
        public void Editcontact(string name)
        {
            foreach (var contact in addresslist)
            {
                if (contact.firstname == name.ToLower() || contact.lastname == name.ToLower())
                {
                    bool flag = true;
                    while (flag == true)
                    {
                        Console.WriteLine("what to be edited:\n1.firstname\n2.lastname\n3.address\n4.city\n5.state\n6.zip\n7.phone.no\n8.email-id\n9.exit");
                        int option = Convert.ToInt32(Console.ReadLine());
                        switch (option)
                        {
                            case 1:
                                string Firstname = Console.ReadLine();
                                contact.firstname = Firstname;
                                Display();
                                break;
                            case 2:
                                string Lastname = Console.ReadLine();
                                contact.lastname = Lastname;
                                Display();
                                break;
                            case 3:
                                string address = Console.ReadLine();
                                contact.Address = address;
                                Display();
                                break;
                            case 4:
                                string City = Console.ReadLine();
                                contact.city = City;
                                Display();
                                break;
                            case 5:
                                string State = Console.ReadLine();
                                contact.state = State;
                                Display();
                                break;
                            case 6:
                                string Zip = Console.ReadLine();
                                contact.zip = Zip;
                                Display();
                                break;
                            case 7:
                                string PhoneNo = Console.ReadLine();
                                contact.phone_number = PhoneNo;
                                Display();
                                break;
                            case 8:
                                string emailid = Console.ReadLine();
                                contact.email_id = emailid;
                                Display();
                                break;
                            case 9:
                                flag = false;
                                break;
                            default:
                                Console.WriteLine("your choice should be between 1 to 9");
                                break;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// method for deleting contacts
        /// </summary>
        /// <param name="name"></param>
        public void DeleteContact(string name)
        {
            Contact contact = new Contact();
            foreach (var contactObj in addresslist)
            {
                if (contactObj.firstname == name.ToLower() || contactObj.lastname == name.ToLower())
                {
                    contact = contactObj;
                }
            }
            addresslist.Remove(contact);
            Console.WriteLine(name + " :" + "contact has deleted");
        }
        /// <summary>
        /// method  for Displaying contacts
        /// </summary>
        public void Display()
        {
            foreach (var contact in addresslist)
            {
                Console.WriteLine("firstname =" + contact.firstname);
                Console.WriteLine("lastname =" + contact.lastname);
                Console.WriteLine("Address =" + contact.Address);
                Console.WriteLine("City =" + contact.city);
                Console.WriteLine("State =" + contact.state);
                Console.WriteLine("Zip =" + contact.zip);
                Console.WriteLine("Phone-Number =" + contact.phone_number);
                Console.WriteLine("Email-Id =" + contact.email_id);
            }

        }

    }
}
