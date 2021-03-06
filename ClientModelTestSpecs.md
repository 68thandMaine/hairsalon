# Client Testing
<sup> **Developer Note**: As of Dec 12, 2018 I have not finished testing all of these specs.</sup>  

The Client object is the child object in this application. Tests were written for Client objects before Stylist objects and controller testing. For a method to be considered ready for use in production code, it must first fail an `AreEqual()` test, then code must be added so that it will pass the `AreEqual()` test.
###### _[Return to ReadMe](../master/ReadMe.md)_
---

#### Test to see if the constructor creates an appropriate instance of the Client type.
>We will not be able To fail this test, without a compile error, thus the only test we need is a passing test. A passing test means that .NET is working correctly.
#### Test to see if the get methods return the correct values.

  ### `GetName()`  

  FAIL:  
>To fail this test, our `public void  GetName()` returns a string that is not equivalent to the name passed into the Client constructor.  

  PASS:  
 >To pass this test, our `public void  GetName()` should `return _name`.

 ### `SetName()`
  FAIL
    >To fail this test, we will set the return value to any string other than what is being passed into the constructor in the test file. eg ... `_name = "robert";`

  PASS
  >To pass this test, we will set method to `_name = newName;`

  ### `GetId()`  

  FAIL:
 >To fail this test, our `public void  GetId()` returns an integer that is not equivalent to the name passed into the Client constructor.  

  PASS:  
 >To pass this test, our `public void  GetId()` should `return _id`.

  #### Test to see if the Database correctly returns an empty list.  

  ##### `GetAll()`

 Test to see if you can return an empty list and then test to see if you can return a populated list.

  FAIL:
  >To fail this test, our `public static List<Client> GetAll()` will return a dummy list that is not connected to the database. This is because our test database is already an empty database. The dummy List<Client> will contain an object in it.

  PASS:
>To pass this test, our `public static List<Client>GetAll()` will return the test database. We replaced the dummy list with a SQL command that returns the test database.

  ##### `public overrride bool Equals()`
  _In order to compare objects made from the same constructor, we need an override so that our Equals method will see these objects as equivalent._

  FAIL  
  >To fail this test,  change the syntax in our override statement so that it returns false if two objects were created from the same constructor.

  PASS
  >To pass this test, alter the code so that if two objects were created from the same constructor, the for loop will set the values equal to each other so that `Equals` returns true.

  ##### `Save()`

  FAIL
  >To fail this test, our   `public void Save()` will not have any logic inside of it. Voids do not need to return anything, so by not including code we can compile the code and fail the test.

  PASS
  >To pass this test, our  `public void Save()` will contain the code for connecting to the Database and the SQL commands necessary for saving to the database.

  ##### `Find(int id)`

  FAIL
  >To fail this test, set the return to `public static Client Find(int id)` to a random hardcoded Client object.

  PASS
  >To pass this test, open a MySqlConnection and use SQL queries to find Clients and return them based off of an Id.a
