import mongoose from "mongoose";

const clientSchema = new mongoose.Schema({
  firstName: String,
  lastName: String,
  email: { type: String, index: true },
});

export default mongoose.model("client", clientSchema);
