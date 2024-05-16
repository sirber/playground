import mongoose from "mongoose";

const userSchema = new mongoose.Schema({
  firstName: String,
  lastName: String,
  email: {
    type: String,
    unique: true,
    index: true,
  },
  roles: String,
  password: String,
  active: Boolean,
  createdAt: Date,
  updatedAt: Date,
  deletedAt: Date,
});

export default mongoose.model("user", userSchema);
