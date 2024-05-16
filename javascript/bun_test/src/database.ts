import mongoose from "mongoose";

export async function connectDb(mongoUri: string) {
  return mongoose
    .connect(mongoUri)
    .then(() => {
      console.log("[database]: Database is connected!");
    })
    .catch((error) => {
      console.error("[database]: Database could not connected!");
      throw error;
    });
}
