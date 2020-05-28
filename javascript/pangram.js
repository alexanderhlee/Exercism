export const isPangram = (inputString) => {
  let uniqueLetters = inputString.replace(/[^A-Za-z]/g,'').toLowerCase();
  let uniqueSet = new Set(uniqueLetters);
  return uniqueSet.size === 26;
};