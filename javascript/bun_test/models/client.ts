import mongoose from "mongoose";

const clientSchema = new mongoose.Schema({
  userId: {
    type: mongoose.Schema.Types.ObjectId,
    required: true,
    index: true,
  },
  firstName: String,
  lastName: String,
  email: {
    type: String,
    index: true,
  },
});

export default mongoose.model("client", clientSchema);
