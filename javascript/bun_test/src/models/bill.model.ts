import mongoose from "mongoose";

const productSchema = new mongoose.Schema({
  name: String,
  price: Number,
  quantity: Number,
});

const paymentSchema = new mongoose.Schema({
  amount: Number,
  createdAt: Date,
  updatedAt: Date,
  deletedAt: Date,
});

const billSchema = new mongoose.Schema({
  userId: {
    type: mongoose.Types.ObjectId,
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
