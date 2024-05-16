/* global use, db */

var mongoose = require('mongoose');
var getObjectId = () => new mongoose.Types.ObjectId();

const { faker } = require('@faker-js/faker');

function getRandomElement(array) {
  const randomIndex = Math.floor(Math.random() * array.length);
  return array[randomIndex];
}

// Cleanup
use('test');
db.users.drop();
db.clients.drop();
db.createCollection('users');
db.createCollection('clients');

// Factory
function getUsers(howMany = 10) {
  function getUser() {
    return {
      _id: getObjectId(), 
      firstName: faker.person.firstName(), 
      lastName: faker.person.lastName(), 
      email: faker.internet.email(), 
      createdAt: faker.date.past(), 
      updatedAt: faker.date.soon()
    };
  }

  const users = [];
  for (let i = 0; i < howMany; i++) {
    users.push(getUser());
  }

  return users;
}

function getClients(userIds, howMany = 40) {
  function getClient() {
    return {
      _id: getObjectId(), 
      userId: getRandomElement(userIds),
      firstName: faker.person.firstName(), 
      lastName: faker.person.lastName(), 
      email: faker.internet.email(), 
      createdAt: faker.date.past(), 
      updatedAt: faker.date.soon()
    };
  }

  const clients = [];
  for (let i = 0; i < howMany; i++) {
    clients.push(getClient());
  }

  return clients;
}

// Users
const users = getUsers(4);
db.users.insertMany(users);

// Clients
const clients = getClients(users.map(u => u._id), 10);
db.clients.insertMany(clients);