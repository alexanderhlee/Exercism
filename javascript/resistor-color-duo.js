const COLORS = ["black","brown","red","orange","yellow","green","blue","violet","grey","white"];

export const decodedValue = ([color1, color2]) => {
  const INIT_VAL = -1;
  let firstNum = INIT_VAL;
  let secondNum = INIT_VAL;
  
  if (color1 && color2) {
    firstNum = getColorIdx(color1) * 10;
    secondNum = getColorIdx(color2);
  }

  if (firstNum > INIT_VAL && secondNum > INIT_VAL) {
    return firstNum + secondNum;
  }
  
  return INIT_VAL;
};

function getColorIdx(colorName) {
  return COLORS.indexOf(colorName);
}