// Config
import dotenv from "dotenv";
dotenv.config();

// Database
import mongoose from "mongoose";
const mongoUri = process.env.MONGO_URI;
if (!mongoUri) {
  throw new Error("MongoDB configuration not found");
}
mongoose
  .connect(mongoUri)
  .then(() => {
    console.log("[database]: Database is connected!");
  })
  .catch((error) => {
    console.error("[database]: Database could not connected!");
    throw error;
  });

// Express
import express, { type Express, type Request, type Response } from "express";
const app: Express = express();
const port = process.env.PORT || 3000;

app.get("/", (req: Request, res: Response) => {
  res.send("Express + TypeScript Server");
});

// - Routes
import clientRoutes from "./routes/clients";
app.use("/clients", clientRoutes);

app.listen(port, () => {
  console.log(`[server]: Server is running at http://localhost:${port}`);
});
