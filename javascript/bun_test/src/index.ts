// Config and Helpers
import { mongoUri } from "./config";

// Database
import { connectDb } from "./database";
await connectDb(mongoUri);

// Express
import express, {
  type Express,
  type Request,
  type Response,
  type NextFunction,
} from "express";
import errorHandler, { Guards } from "errors-express";
import session from "express-session";
import MongoStore from "connect-mongo";

const app: Express = express();
const port = process.env.PORT || 3000;

// Middlewares
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

app.use((req: Request, res: Response, next: NextFunction) => {
  next();

  if (res.statusCode >= 200 && res.statusCode < 400) {
    logAccess(`${req.method} ${req.url} status:${res.statusCode}`);
  }
});

// Routes
app.get("/", (req: Request, res: Response) => {
  res.send("Express + TypeScript Server");
});

app.get("/error", (req: Request, res: Response, next: NextFunction) => {
  throw new Error("error");
});

import {
  router as clientsRouter,
  name as clientsRoute,
} from "./routes/client.route";
import { getEnv } from "./helpers/env";
import { log, logAccess } from "./helpers/logger";
app.use("/" + clientsRoute, clientsRouter);

app.all("*", Guards.NotFound());

// Error Handling
app.use(
  errorHandler((error: Error, req: Request, res: Response) => {
    logAccess(
      `${req.method} ${req.url} status:${res.statusCode} ${error.message}`,
      req.ip
    );
  })
);

// App
app.listen(port, () => {
  log(`Server is running at http://localhost:${port}`);
  log(`Environment is: ${getEnv()}`);
});
