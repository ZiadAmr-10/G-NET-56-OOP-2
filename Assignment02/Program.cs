namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01
            #region Q01
            /*
        a)1-No protection for data because the fields are public and can Access the felds directly and can modify it
          2-No validation to validate the amount before subtracting it from the balance.
        b)1-make the fields private 
          2-using properties to provide control access of fields
          3-Validate the withdrawal amount before subtracting it from the balance 
        c)Because public fields allow anyone outside the class to access and modify the data directly ,
            and if another project uses this class from a DLL file, and I change a field, the other project must update its code.
             */
            #endregion
            #region Q02
            /*    
            - Field ->Store data directly ,no validation ,if public can anyone access and modify it 
              property->Provide controlled access to data ,can contain  logic and  validate values before storing them,Protects the object's internal state
            - Yes can contain  logic 
             public decimal TotalPrice {
            get{
              return Quantity * UnitPrice;
            }
            }
            or 
            public decimal TotalPrice => Quantity*unitPrice;
            */
            #endregion
            #region Q03
            /*
            .a)its called an indexer 
            .  the purpose is :
            .  allows an object to be accessed using array-like syntax([]). 
            .b)The indexer calls the set accessor and stores "Ali" in names[10].
            .  To make it safer , add validation to check if the index is valid before storing the value.
            .c)Yes,Can have more than one indexer and it's called indexer overloading 
            .  and based on the parameter type the indexer is chosen
            .  it's useful in phonebook , you can search by index or by a person's name. 
             */
            #endregion
            #region Q04
            /*
              a)Static means there is only one shared field for all objects,
                It is not created again for every new object and
                the difference between static and normal field
                The Item field belongs to each object, so every object has its own Item value,
                The TotalOrders field is shared by all objects and it stores the total number of orders 
              b)No,because item is a normal field 
                and static method can only access static members directly 
                because it does not belong to a specific object.
            */


            
            #endregion
            #endregion
        }
    }
}
