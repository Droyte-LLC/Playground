/**
 * A container of integers that should support
 * addition, removal, and search for the median integer
 */
class Container {
  numbers: number[];
  constructor() {
    this.numbers = [];
  }

  /**
   * Adds the specified value to the container
   */
  add(value: number): void {
    this.numbers.push(value);
    this.numbers = this.numbers.sort((a,b) => a - b);
  }

  /**
   * Attempts to delete one item of the specified value from the container
   *
   * @return {boolean} true, if the value has been deleted, or
   *                   false, otherwise.
   */
  delete(value: number): boolean {
    const indexToRemove = this.numbers.indexOf(value);
    
    if(indexToRemove !== -1) {
      this.numbers.splice(indexToRemove, 1);

      return true;
    }
    
    return false;
  }

  /**
   * Finds the container's median integer value, which is
   * the middle integer when the all integers are sorted in order.
   * If the sorted array has an even length,
   * the leftmost integer between the two middle
   * integers should be considered as the median.
   *
   * @return {number} the median if the array is not empty, or
   * @throws {Error} a runtime exception, otherwise.
   */
  getMedian(): number {
    if(this.numbers.length < 1) {
      throw new Error('Error')
    }
    
    let midIndex = Math.floor(this.numbers.length / 2);
    
    if(this.numbers.length % 2 == 0) {
      return this.numbers[midIndex - 1];
    } else {
      return this.numbers[midIndex];
    }
  }
}

export default Container;
