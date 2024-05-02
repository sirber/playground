import unittest

from count_repetition import count_repetition

class TestCountRepetition(unittest.TestCase):
  def test1(self):
    test = [1,2,2,3,3,3]
    result = count_repetition(test)
    self.assertEqual(3, result)
  
  def test2(self):
    test = [1,1,2,2,3,3]
    result = count_repetition(test)
    self.assertEqual(3, result)

  def test3(self):
    test = [1,2,1,2,1,2]
    result = count_repetition(test)
    self.assertEqual(4, result)

if __name__ == '__main__':
  unittest.main()