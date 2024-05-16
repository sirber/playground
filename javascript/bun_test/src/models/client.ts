import mongoose from "mongoose";

const clientSchema = new mongoose.Schema({
  id: {
    type: String,
    unique: true,
    index: true,
    required: true,
  },
  userId: {
    type: String,
    index: true,
    required: true,
  },
  firstName: String,
  lastName: String,
  email: {
    type: String,
    unique: true,
    index: true,
  },
});

export default mongoose.model("client", clientSchema);
