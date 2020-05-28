const rnaTransTable = {
  'G': 'C',
  'C': 'G',
  'T': 'A',
  'A': 'U'
};

export const toRna = (str) => {
  return str.replace(/[A-Z]/g, function (match) {
    return rnaTransTable[match];
  });
};