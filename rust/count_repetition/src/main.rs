use std::collections::HashMap;

fn main() {
  println!("Please run unit tests");
}

pub fn count_repetition(source: &[i32]) -> i32 {
  let mut map: HashMap<i32, i32> = HashMap::new();

  for &number in source {
    let count = map.entry(number).or_insert(0);
    *count += 1;
  }

  let mut repetition_count = 0;
  for &repetition in map.values() {
    repetition_count += repetition - 1; // Subtract 1 because we're counting repetitions, not occurrences.
  }

  repetition_count
}

#[cfg(test)]
mod tests {
  use super::*;

  #[test]
  fn test_count_repetition() {
    // Test case 1: Test with a simple array
    let source1 = vec![1, 2, 2, 3, 3, 3];
    assert_eq!(count_repetition(&source1), 3);

    // Test case 2: Test with an empty array
    let source2: Vec<i32> = Vec::new();
    assert_eq!(count_repetition(&source2), 0);

    // Test case 3: Test with an array containing only one element
    let source3 = vec![1];
    assert_eq!(count_repetition(&source3), 0);
  }
}
