import mongoose from "mongoose";

const productSchema = new mongoose.Schema({
  id: {
    type: String,
    unique: true,
    index: true,
    required: true,
  },
  name: String,
  price: Number,
  quantity: Number,
});

const paymentSchema = new mongoose.Schema({
  id: {
    type: String,
    unique: true,
    index: true,
    required: true,
  },
  amount: Number,
  createdAt: Date,
  updatedAt: Date,
  deletedAt: Date,
});

const billSchema = new mongoose.Schema({
  id: {
    type: String,
    unique: true,
    index: true,
    required: true,
  },
  products: [productSchema],
  payments: [paymentSchema],
  createdAt: Date,
  updatedAt: Date,
  deletedAt: Date,
});

export default mongoose.model("bill", billSchema);
