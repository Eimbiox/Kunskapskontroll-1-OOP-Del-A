//All the tests needed to show that everything works as needed, remove */ /* to try each test

//Makes 3 student objects and 2 course objects
Student eimantas = new("Eimantas");
Student ella = new("Ella");
Student boltas = new("Boltas");

Course english = new("English", 2);
Course swedish = new("Swedish", 2);

//Test to show that adding objects to list works 

/*
english.Enroll(eimantas);
ella.Join(english);
english.RollCall();
*/

//Test to show that duplicate protection works

/*
eimantas.Join(english);
eimantas.Join(english);
english.Enroll(eimantas);
*/

//Test to show that capacity limit works

/*
eimantas.Join(english);
ella.Join(english);
boltas.Join(english);
english.Enroll(boltas);
*/

//Test to show that removal works both ways

/*
eimantas.Join(english);
boltas.Join(english);

english.RollCall();
System.Console.WriteLine("");

eimantas.Leave(english);
english.RollCall();
System.Console.WriteLine("");

english.Remove(eimantas);
english.Remove(boltas);

english.RollCall();
eimantas.Schedule();
*/

//Test to show that ToString override works correctly

/*
System.Console.WriteLine(english);
english.Enroll(eimantas);
boltas.Join(english);
System.Console.WriteLine(english);
System.Console.WriteLine(swedish);
System.Console.WriteLine(eimantas);
System.Console.WriteLine(boltas);
*/