import { Router, type Request, type Response } from "express";
import Client from "../models/client";

export const name = "clients";
export const router = Router();

router.get("/", async (req: Request, res: Response) => {
  const clients = await Client.find();
  res.json(clients);
});
