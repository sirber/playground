import mongoose from "mongoose";

const clientSchema = new mongoose.Schema({
  userId: {
    type: mongoose.Types.ObjectId,
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
  createdAt: Date,
  updatedAt: Date,
  deletedAt: Date,
});

export default mongoose.model("client", clientSchema);
