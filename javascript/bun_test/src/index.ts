// Config
import { mongoUri } from "./config";

// Database
import { connectDb } from "./database";
await connectDb(mongoUri);

// Express
import express, { type Express, type Request, type Response } from "express";
import session from "express-session";
import MongoStore from "connect-mongo";

const app: Express = express();
const port = process.env.PORT || 3000;

app.use(
  session({
    store: MongoStore.create({
      mongoUrl: mongoUri,
    }),
    secret: process.env.secret || "dev",
    resave: true,
    saveUninitialized: true,
  })
);

app.get("/", (req: Request, res: Response) => {
  res.send("Express + TypeScript Server");
});

// - Routes
import {
  router as clientsRouter,
  name as clientsRoute,
} from "./routes/clients";
app.use("/" + clientsRoute, clientsRouter);

app.listen(port, () => {
  console.log(`[server]: Server is running at http://localhost:${port}`);
});
