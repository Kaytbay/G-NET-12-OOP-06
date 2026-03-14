namespace oop_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 1 :

            #region Q1:

            //Q1 : What is abstraction in OOP?
            //How is it different from encapsulation?
            //Give a real-world example (not from the session) that shows the difference between the two.

            // is show what the user need  what object does not how 
            // it is diff  because encapculation How data is protected with Access modifiers, Properties

            //abstraction : on the laptop you press the power button we donot need to know how the things happened to open the lap
            //encaosulation :all the physical component  are hidden




            #endregion

            #region Q2:

            // Q2 : What is the difference between an abstract class and an interface?
            // Give at least four differences.
            // When would you choose one over the other?


            // the interface define the bahavior itis about role and capabilities
            // abstract class about the identity  what you are  (is a)
            // interface :Multiple inheritance needed ,Represents a capability
            // abstract class : Shared implementation required, is a , Has constructors / fields



            #endregion

            #region Q3 :
            /*
             public abstract class Appliance{
                public string Brand { get; set; }
                protected Appliance(string brand) { Brand = brand; }
                public abstract double PowerConsumption();
                public virtual string Status() => "Standby";
                public string Label() => $"{Brand} - {PowerConsumption()}W";
            }
            public class WashingMachine : Appliance{
                public WashingMachine(string brand) : base(brand) { }
                public override double PowerConsumption() => 500;
                public override string Status() => "Washing";
            }
            public class Toaster : Appliance{
                public Toaster(string brand) : base(brand) { }
                public override double PowerConsumption() => 800;
            }
             */

            //a) Can you write: Appliance a = new Appliance("LG"); ? Why or why not?
            //b) What is the difference between the three methods: PowerConsumption(), Status(), and Label()?
            //Why did the designer make each one abstract, virtual, or concrete?
            //c) If you call Status() on a Toaster object, what will it return? Why?


            // no , cannot create object from abstract class

            // PowerConsumption() : is abstract method should be override
            // Status() : virtual method can be override or use the default impelementation
            // Label() : cannot be override  only inherite the implementation

            // it will return a "standby"  because this is default implementation from the Appliance base class

            #endregion


            #region Q4:
            /*
                // File: Calculator.cs
                public partial class Calculator {
                    public double LastResult { get; private set; }
                    partial void OnCalculated(double result);
                    public double Add(double a, double b) {
                        LastResult = a + b;
                        OnCalculated(LastResult);
                        return LastResult;
                    }
                }
                // File: Calculator.Logging.cs
                public partial class Calculator{
                    partial void OnCalculated(double result){
                        Console.WriteLine($"Log: result = {result}");
                    }
                }
                // File: DoubleExtensions.cs
                public static class DoubleExtensions {
                    public static string ToCurrency(this double value)
                        => $"${value:F2}";
                }
             */
            //a) What is a partial class? Why would a developer split Calculator into two files?
            //b) What is a partial method? What happens if the OnCalculated() implementation in Calculator.Logging.cs is deleted — will the code still compile? Why?
            //c) What is an extension method? What are the three rules for writing one?
            //d) What will the following code print?
            /*
             * Calculator calc = new Calculator();
            double result = calc.Add(19.5, 0.5);
            Console.WriteLine(result.ToCurrency());
            */

            //a // A partial class allows you to split a single class definition across multiple files 
            // to organize a large classes , team collaboration

            //b  // A method defined in one part of a partial class, and its implementationin another part
            // yes the code will compile because the the compiler removes the call

            //c //add new methods to an existing type 
            //static class, static method ,this keyword

            // 20.0 in currency : $20.00



            #endregion
            #endregion
        }
    }
}
