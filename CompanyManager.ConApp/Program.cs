namespace CompanyManager.ConApp
{
    internal class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(/*string[] args*/)
        {
            string input = string.Empty;
            Logic.Contracts.IContext context = Logic.DataContext.Factory.CreateContext();

            while (!input.Equals("x", StringComparison.CurrentCultureIgnoreCase))
            {
                int index = 1;
                Console.Clear();
                Console.WriteLine("CompanyManager");
                Console.WriteLine("==========================================");

                Console.WriteLine($"{nameof(PrintCompanyies),-25}....{index++}");
                Console.WriteLine($"{nameof(QueryCompanies),-25}....{index++}");
                Console.WriteLine($"{nameof(AddCompany),-25}....{index++}");
                Console.WriteLine($"{nameof(DeleteCompany),-25}....{index++}");
                Console.WriteLine($"{nameof(PrintEmployees),-25}....{index++}");
                Console.WriteLine($"{nameof(QuerEmployees),-25}....{index++}");
                Console.WriteLine($"{nameof(AddEmployee),-25}....{index++}");
                Console.WriteLine($"{nameof(DeleteEmployee),-25}....{index++}");

                Console.WriteLine();
                Console.WriteLine($"Exit...............x");
                Console.Write("Your choice: ");

                input = Console.ReadLine()!;
                if (Int32.TryParse(input, out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            PrintCompanyies(context);
                            Console.WriteLine();
                            Console.Write("Continue with Enter...");
                            Console.ReadLine();
                            break;
                        case 2:
                            QueryCompanies(context);
                            Console.WriteLine();
                            Console.Write("Continue with Enter...");
                            Console.ReadLine();
                            break;
                        case 3:
                            AddCompany(context);
                            break;
                        case 4:
                            DeleteCompany(context);
                            break;
                        case 5:
                            PrintEmployees(context);
                            Console.WriteLine();
                            Console.Write("Continue with Enter...");
                            Console.ReadLine();
                            break;
                        case 6:
                            QuerEmployees(context);
                            Console.WriteLine();
                            Console.Write("Continue with Enter...");
                            Console.ReadLine();
                            break;
                        case 7:
                            AddEmployee(context);
                            break;
                        case 8:
                            DeleteEmployee(context);
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        /// <summary>
        /// Prints all companies in the context.
        /// </summary>
        /// <param name="context">The database context.</param>
        private static void PrintCompanyies(Logic.Contracts.IContext context)
        {
            Console.WriteLine();
            Console.WriteLine("Companies:");
            Console.WriteLine("----------");

            throw new NotImplementedException();
        }

        /// <summary>
        /// Queries companies based on a user-provided condition.
        /// </summary>
        /// <param name="context">Thedatabase context.</param>
        private static void QueryCompanies(Logic.Contracts.IContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Adds a new company to the context.
        /// </summary>
        /// <param name="context">Thedatabase context.</param>
        private static void AddCompany(Logic.Contracts.IContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes a company from the context.
        /// </summary>
        /// <param name="context">Thedatabase context.</param>
        private static void DeleteCompany(Logic.Contracts.IContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Prints all employees in the context.
        /// </summary>
        /// <param name="context">Thedatabase context.</param>
        private static void PrintEmployees(Logic.Contracts.IContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Queries employees based on a user-provided condition.
        /// </summary>
        /// <param name="context">Thedatabase context.</param>
        private static void QuerEmployees(Logic.Contracts.IContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Adds a new employee to the context.
        /// </summary>
        /// <param name="context">Thedatabase context.</param>
        private static void AddEmployee(Logic.Contracts.IContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes an employee from the context.
        /// </summary>
        /// <param name="context">Thedatabase context.</param>
        private static void DeleteEmployee(Logic.Contracts.IContext context)
        {
            throw new NotImplementedException();
        }
    }
}
