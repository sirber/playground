import { Router, type Request, type Response } from "express";
import Client from "../models/client";

const router = Router();

router.get("/", async (req: Request, res: Response) => {
  const clients = await Client.find();

  res.json(clients);
});

export default router;
