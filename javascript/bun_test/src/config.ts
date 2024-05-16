import dotenv from "dotenv";
dotenv.config();

export const mongoUri: string = process.env.MONGO_URI ?? "";
if (!mongoUri) {
  throw new Error("MongoDB configuration not found");
}
