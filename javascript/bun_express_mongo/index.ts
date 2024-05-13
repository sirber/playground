import express, { type Express, type Request, type Response } from "express";
import dotenv from "dotenv";
import mongoose from "mongoose";

import Client from "./models/client";

dotenv.config();

// Database
const mongoUri = process.env.MONGO_URI;
if (!mongoUri) {
  throw new Error("MongoDB configuration not found");
}
mongoose.connect(mongoUri).then(() => {
  console.log("[database]: Database is connected!");
});

// Express
const app: Express = express();
const port = process.env.PORT || 3000;

app.get("/", (req: Request, res: Response) => {
  res.send("Express + TypeScript Server");
});

app.get("/clients", async (req: Request, res: Response) => {
  const clients = await Client.find();

  res.json(clients);
});

app.listen(port, () => {
  console.log(`[server]: Server is running at http://localhost:${port}`);
});
