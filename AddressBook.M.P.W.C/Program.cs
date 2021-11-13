using System;
using AddressBook.M.P.W.C.Contacts;
using AddressBook.M.P.W.C.Repository;

namespace AddressBook.M.P.W.C
{
    class Program
    {
        static void Main(string[] args)
        {
            byte choise = 255;

            ContactService contactService = new ContactService();

            Console.WriteLine("Welcome to Address Book System!");
            Console.WriteLine();

            do
            {
                Console.WriteLine("You can choose following choises: ");
                Console.WriteLine();
                Console.WriteLine("1. New contact");
                Console.WriteLine("2. Update contact");
                Console.WriteLine("3. Find contact");
                Console.WriteLine("4. Delete contact");
                Console.WriteLine("5. Show Info contact");
                Console.WriteLine("0. Exit");


                if (byte.TryParse(Console.ReadLine(), out choise))
                {
                    switch (choise)
                    {
                        case 1:
                            Info newInfo = new Info();

                            newInfo.Id = contactService.FindId();

                            Console.WriteLine("Enter the name: ");
                            newInfo.Name = Console.ReadLine();

                            Console.WriteLine("Enter the surname: ");
                            newInfo.Surname = Console.ReadLine();

                            Console.WriteLine("Enter the age: ");
                            newInfo.Age = Convert.ToByte(Console.ReadLine());

                            Console.WriteLine("Enter the address: ");
                            newInfo.Address = Console.ReadLine();

                            Console.WriteLine("Enter the Phone number: ");
                            newInfo.Telephone = Console.ReadLine();

                            contactService.New(newInfo);

                            Console.WriteLine();
                            break;

                        case 2:
                            Console.WriteLine("Select Id for Update: ");

                            foreach (var item in contactService.ShowInfo())
                            {
                                Console.WriteLine($"Id: {item.Id}, Name: {item.Name}, Surname: {item.Surname}, Age: {item.Age}, Telephone: {item.Telephone}, Address: {item.Address}");
                            }

                            int empId = Convert.ToInt32(Console.ReadLine());
                            Info info = contactService.Find(empId);

                            Console.WriteLine($"Enter new Name: {info.Name}");
                            info.Name = Console.ReadLine();

                            Console.WriteLine($"Enter new Surame: {info.Surname}");
                            info.Surname = Console.ReadLine();

                            Console.WriteLine($"Enter new Age: {info.Age}");
                            info.Age = Convert.ToByte(Console.ReadLine());

                            Console.WriteLine($"Enter new Address: {info.Address}");
                            info.Address = Console.ReadLine();

                            Console.WriteLine($"Enter new Phone Number: {info.Telephone}");
                            info.Telephone = Console.ReadLine();

                            contactService.Update(empId, info);

                            Console.WriteLine("Successfully Updateed");
                            Console.WriteLine();
                            break;

                        case 3:
                            Console.WriteLine("Enter Id");
                            int Id = Convert.ToInt32(Console.ReadLine());
                            Info info1 = contactService.Find(Id);
                            Console.WriteLine($"Id: {info1.Id}, Name: {info1.Name}, Surname: {info1.Surname}, Age: {info1.Age}, Telephone: {info1.Telephone}, Address: {info1.Address}");

                            Console.WriteLine();    
                            break;

                        case 4:
                            Console.WriteLine("Select Id for Delete");

                            Info[] fullInfo2 = contactService.ShowInfo();

                            for (int i = 0; i < fullInfo2.Length; i++)
                            {
                                Console.WriteLine($"{i + 1}. Id: {fullInfo2[i].Id}, Name: {fullInfo2[i].Name}, Surname: {fullInfo2[i].Surname}, Age: {fullInfo2[i].Age}, Telephone: {fullInfo2[i].Telephone}, Address: {fullInfo2[i].Address}");
                            }

                            int deleteId = Convert.ToInt32(Console.ReadLine());
                            contactService.Delete(deleteId);

                            Console.WriteLine("Successfully Deleted");
                            Console.WriteLine();
                            break;


                        case 5:
                            Info[] fullInfo = contactService.ShowInfo();

                            for (int i = 0; i < fullInfo.Length; i++)
                            {
                                Console.WriteLine($"{i+1}. Id: {fullInfo[i].Id}, Name: {fullInfo[i].Name}, Surname: {fullInfo[i].Surname}, Age: {fullInfo[i].Age}, Telephone: {fullInfo[i].Telephone}, Address: {fullInfo[i].Address}");
                            }

                            Console.WriteLine();
                            break;

                        case 0:
                            Console.WriteLine("Exit");
                            Console.WriteLine();
                            break;

                        default:
                            Console.WriteLine("Choose only those options that are on the list!");
                            Console.WriteLine();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Enter only the number that is on the list!");
                    Console.WriteLine();
                    choise = 255;
                }

            } while (choise != 0);
        }
    }
}
