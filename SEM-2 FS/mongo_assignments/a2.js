const mongoose = require("mongoose");

// Connect to MongoDB
mongoose.connect(
  "mongodb+srv://Ashish224:AshishKc225@peopleDB.b27zde6.mongodb.net/?retryWrites=true&w=majority&appName=TicketSys",
  {
    useNewUrlParser: true,
    useUnifiedTopology: true,
  }
);

// Create Restaurant Schema
const restaurantSchema = new mongoose.Schema({
  restaurant_id: String,
  name: String,
  address: {
    city: String,
    building: String,
    street: String,
    pincode: Number,
  },
  cuisine: String,
  grades: [
    {
      date: Date,
      score: Number,
      grade: String, // 'A', 'B', etc.
    },
  ],
});

// Create Model
const Restaurant = mongoose.model("Restaurant", restaurantSchema);

const insertRestaurants = async () => {
  await Restaurant.insertMany([
    {
      restaurant_id: "R001",
      name: "Spice Villa",
      address: {
        city: "Pune",
        building: "101",
        street: "MG Road",
        pincode: 411001,
      },
      cuisine: "Indian",
      grades: [{ date: new Date(), score: 88, grade: "B" }],
    },
    {
      restaurant_id: "R002",
      name: "Italiano",
      address: {
        city: "Pune Camp",
        building: "22",
        street: "Main Street",
        pincode: 411001,
      },
      cuisine: "Italian",
      grades: [{ date: new Date(), score: 92, grade: "A" }],
    },
    {
      restaurant_id: "R003",
      name: "Burger Hub",
      address: {
        city: "Mumbai",
        building: "55A",
        street: "Link Road",
        pincode: 400001,
      },
      cuisine: "Fast Food",
      grades: [{ date: new Date(), score: 78, grade: "B" }],
    },
    {
      restaurant_id: "R004",
      name: "Sushi World",
      address: {
        city: "Pune Camp",
        building: "300",
        street: "MG Road",
        pincode: 411001,
      },
      cuisine: "Japanese",
      grades: [{ date: new Date(), score: 95, grade: "A" }],
    },
    {
      restaurant_id: "R005",
      name: "Tandoori Express",
      address: {
        city: "Delhi",
        building: "1C",
        street: "Rajpath",
        pincode: 110001,
      },
      cuisine: "Indian",
      grades: [{ date: new Date(), score: 60, grade: "B" }],
    },
    {
      restaurant_id: "R006",
      name: "China Town",
      address: {
        city: "Pune",
        building: "502",
        street: "FC Road",
        pincode: 411004,
      },
      cuisine: "Chinese",
      grades: [{ date: new Date(), score: 85, grade: "B" }],
    },
  ]);

  console.log("Sample restaurants inserted.");
};

const showFirstFive = async () => {
  const result = await Restaurant.find().limit(5);
  console.log("First 5 Restaurants:", result);
};

const showAllRestaurants = async () => {
  const result = await Restaurant.find();
  console.log("All Restaurants:", result);
};

const showPuneCampRestaurants = async () => {
  const result = await Restaurant.find({ "address.city": "Pune Camp" });
  console.log("Restaurants in Pune Camp:", result);
};

const showHighScoreRestaurants = async () => {
  const result = await Restaurant.find({ "grades.score": { $gt: 90 } });
  console.log("Restaurants with score > 90:", result);
};
const run = async () => {
  // Uncomment if inserting data for the first time
  await insertRestaurants();

  await showFirstFive();
  await showAllRestaurants();
  await showPuneCampRestaurants();
  await showHighScoreRestaurants();

  mongoose.connection.close();
};

run();
