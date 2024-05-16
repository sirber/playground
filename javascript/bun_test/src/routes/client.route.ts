import { Router, type Request, type Response } from "express";
import { ClientService } from "../services/client.service";

export const name = "clients";
export const router = Router();

export const clientService = new ClientService();

router.get("/", async (req: Request, res: Response) => {
  res.json(await clientService.getClients());
});
