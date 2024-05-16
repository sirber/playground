/* global use, db */

const { v4 } = require('uuid');
const { faker } = require('@faker-js/faker');

function getRandomElement(array) {
  const randomIndex = Math.floor(Math.random() * array.length);
  return array[randomIndex];
}

// Cleanup
use('test');
db.getCollection('users').deleteMany({});
db.getCollection('clients').deleteMany({});

// Factory
function getUsers(howMany = 10) {
  function getUser() {
    return {
      id: v4(), 
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
      id: v4(), 
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
const clients = getClients(users.map(u => u.id), 40);
db.clients.insertMany(clients);