import mongoose from "mongoose";
import { getNow } from "./helpers/date.helper";

export async function connectDb(mongoUri: string) {
  return mongoose
    .connect(mongoUri)
    .then(() => {
      console.log(`[${getNow()}] Database: connected!`);
    })
    .catch((error) => {
      console.error(`[${getNow()}] Database: could not connected!`);
      throw error;
    });
}
