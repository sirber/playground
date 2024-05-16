import Client from "../models/client.model";

export class ClientService {
  async getClients() {
    return await Client.find();
  }
}
