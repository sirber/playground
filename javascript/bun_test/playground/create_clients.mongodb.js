/* global use, db */
// MongoDB Playground
// To disable this template go to Settings | MongoDB | Use Default Template For Playground.
// Make sure you are connected to enable completions and to be able to run a playground.
// Use Ctrl+Space inside a snippet or a string literal to trigger completions.
// The result of the last command run in a playground is shown on the results panel.
// By default the first 20 documents will be returned with a cursor.
// Use 'console.log()' to print to the debug output.
// For more documentation on playgrounds please refer to
// https://www.mongodb.com/docs/mongodb-vscode/playgrounds/

const mongoose = require("mongoose");
const { ObjectId } = mongoose.Types;

// Select the database to use.
use('test');

// Insert a few documents into the sales collection.
db.getCollection('clients').insertMany([
  { userId: new ObjectId() ,firstName: "Bob", lastName: "Roger", email: "bob@roger.com" }
]);

