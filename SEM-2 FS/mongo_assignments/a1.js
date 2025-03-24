const mongoose = require("mongoose");

// Connect to MongoDB
mongoose.connect(
  "mongodb+srv://Ashish224:AshishKc225@peopleDB.b27zde6.mongodb.net/?retryWrites=true&w=majority&appName=TicketSys",
  {
    useNewUrlParser: true,
    useUnifiedTopology: true,
  }
);

// Define the schema
const personSchema = new mongoose.Schema({
  name: String,
  age: Number,
  children: [String],
});

// Create the model
const Person = mongoose.model("Person", personSchema);

const insertPeople = async () => {
  await Person.insertMany([
    { name: "John", age: 99, children: ["Mike", "Sarah"] },
    { name: "Alice", age: 67, children: ["Emma"] },
    { name: "Bob", age: 45, children: [] },
    { name: "Grandpa Joe", age: 99, children: ["Tom", "Jerry"] },
    { name: "Teen Tom", age: 15, children: [] },
    { name: "Teen Jerry", age: 19, children: [] },
    { name: "Young Lucy", age: 13, children: [] },
    { name: "Adult Steve", age: 35, children: ["Junior Steve"] },
  ]);

  console.log("Sample people inserted.");
};

const findAge99 = async () => {
  const result = await Person.find({ age: 99 });
  console.log("People who are exactly 99 years old:", result);
};

const findBusPassEligible = async () => {
  const result = await Person.find({ age: { $gt: 65 } });
  console.log("People eligible for bus pass:", result);
};

const findTeenagers = async () => {
  const result = await Person.find({ age: { $gt: 12, $lt: 20 } });
  console.log("Teenagers:", result);
};

const runQueries = async () => {
  // Uncomment if inserting for the first time
  await insertPeople();

  await findAge99();
  await findBusPassEligible();
  await findTeenagers();

  mongoose.connection.close();
};

runQueries();
