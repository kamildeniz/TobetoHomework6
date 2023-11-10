// See https://aka.ms/new-console-template for more information
using OOP3;

Console.WriteLine("Hello, World!");
PersonalFinanceCredit personalFinanceCredit = new PersonalFinanceCredit();
personalFinanceCredit.Calculate();

TransportCredit transportCredit = new TransportCredit();
transportCredit.Calculate();

HousingCredit housingCredit = new HousingCredit();
housingCredit.Calculate();
ILoggerService databaseLoggerService = new DataBaseLoggerService();
ILoggerService fileLoggerService = new FileLoggerService();
ApplyManager applyManager = new ApplyManager();
//applyManager.Apply(housingCredit, new List<ILoggerService>() { databaseLoggerService, fileLoggerService });

List<ILoggerService> loggers  = new List<ILoggerService>() { databaseLoggerService,fileLoggerService};
applyManager.Apply(transportCredit, loggers);

List<ICreditManager> creditManagers = new List<ICreditManager>() { housingCredit,transportCredit};

//applyManager.CreditPreliminaryInformation(creditManagers);