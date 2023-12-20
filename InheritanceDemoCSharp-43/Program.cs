using InheritanceDemoCSharp_43;


var seth = new Person();
seth.Name = "Seth";
seth.Age = 29;

seth.Greet();

var mack = new Coder();
mack.Name = "Mack";
mack.Age = 24;
mack.ProgrammingLang = "C#";
mack.Greet();
mack.Code();

var cruz = new BackEndDev();

cruz.Name = "Cruz";
cruz.Age = 32;
cruz.ProgrammingLang = "JavaScript";
cruz.Greet();
cruz.Code();