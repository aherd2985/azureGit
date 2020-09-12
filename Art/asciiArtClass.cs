using System;
using System.Collections.Generic;
using System.Text;

namespace AzureGitAPI.Art
{
  class asciiArtClass
  {
    public string[] azureArtArr = new[]
          {
      @"MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWXOOKWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM",
      @"MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMN0xokKNMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM",
      @"MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWXOoccxNWMMMNKNMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM",
      @"MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWKkl::cxNMMMMWOlxXMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM",
      @"MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWN0dc:::cdXMMMMW0l:cdXWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM",
      @"MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWXkoc::::cdXMMMMMXd::::oKWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM",
      @"MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMNKxl:::::::dXMMMMMNkc:::::o0WMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM",
      @"MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWXOdc::::::::oKWMMMWNOl:::::::lONMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM",
      @"MMMMMMMMMMMMMMMMMMMMMMMMMMMMWKko::::::::::oKWMMMWKxo:::::::::ckNMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM",
      @"MMMMMMMMMMMMMMMMMMMMMMMMMMN0xl:::::::::::o0WMMMMXd::::::::::::cxXMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM",
      @"MMMMMMMMMMMMMMMMMMMMMMMWXOoc::::::::::::l0WMMMMNkc:::::::::::::cxXWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM",
      @"MMMMMMMMMMMMMMMMMMMMMMXkl::::::::::::::l0WMMMMW0l:::::::::::::::cdKWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM",
      @"MMMMMMMMMMMMMMMMMMMMWXdc::::::::::::::lOWMMMMMKo::::::::::::::::::o0WMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM",
      @"MMMMMMMMMMMMMMMMMMMWKd:::::::::::::::lOWMMMMMNxc:::::::::::::::::::l0WMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM",
      @"MMMMMMMMMMMMMMMMMMW0o:::::::::::::::ckNMMMMMWOc:::::::::::::::::::::lONMMMMMMMMMMMMMMMMMMMMMMMMMMMMM",
      @"MMMMMMMMMMMMMMMMMWOl:::::::::::::::ckNMMMMMW0l:::::::::::::::::::::::ckNMMMMMMMMMMMMMMMMMMMMMMMMMMMM",
      @"MMMMMMMMMMMMMMMMNOl:::::::::::::::cxNMMMMMMXd:::::::::::::::::::::::::cxXMMMMMMMMMMMMMMMMMMMMMMMMMMM",
      @"MMMMMMMMMMMMMMMNkc:::::::::::::::cxNMMMMMMNxc::::::::::::::::::::::::::cdXWMMMMMMMMMMMMMMMMMMMMMMMMM",
      @"MMMMMMMMMMMMMWXxc:::::::::::::::cxXMMMMMMMKo:::::::::::::::::::::::::::::oKWMMMMMMMMMMMMMMMMMMMMMMMM",
      @"MMMMMMMMMMMMWXdc:::::::::::::::cxXMMMMMMMMWKdc::::::::::::::::::::::::::::o0WMMMMMMMMMMMMMMMMMMMMMMM",
      @"MMMMMMMMMMMWKo:::::::::::::::::dXWMMMMMMMMMMNOo::::::::::::::::::::::::::::lONMMMMMMMMMMMMMMMMMMMMMM",
      @"MMMMMMMMMMW0o:::::::::::::::::dKWMMMMMMMMMMMMWXkl:::::::::::::::::::::::::::ckNMMMMMMMMMMMMMMMMMMMMM",
      @"MMMMMMMMMNOl:::::::::::::::::oKWMMMMMMMMMMMMMMMWKdlc:::::::::::::::::::::::::cxNMMMMMMMMMMMMMMMMMMMM",
      @"MMMMMMMMNkc:::::::::::::::::oKWMMMMMMMMMMMMMMMMMMNXOo:::::::::::::::::::::::::cxXMMMMMMMMMMMMMMMMMMM",
      @"MMMMMMMXxc:::::::::::::::::o0WMMMMMMMMMMMMMMMMMMMMMWXkl:::::::::::::::::::::::::dKWMMMMMMMMMMMMMMMMM",
      @"MMMMMWXdc:::::::::::::::::l0WMMMMMMMMMMMMMMMMMMMMMMMMWKdc::::::::::::::::::::::::o0WMMMMMMMMMMMMMMMM",
      @"MMMMWKd::::::::::::::::::l0WMMMMMMMMMMMMMMMMMMMMMMMMMMMNOoc:::::::::::::::::::::::l0WMMMMMMMMMMMMMMM",
      @"MMMW0o::::::::::::::::::lOWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWXkl:::::::::::::::::::::::lONMMMMMMMMMMMMMM",
      @"MMW0l::::::::::::::::::lONMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWKdc::::::::::::::::::::::ckNMMMMMMMMMMMMM",
      @"MNOl::::::::::::::::::ckNMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMN0o::::::::::::::::::::::cxXMMMMMMMMMMMM",
      @"Nkc::::::::::::::::::ckNMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMXkl:::::::::::::::::::::cdKWMMMMMMMMMM",
      @"klcccccccccccccccccclkNMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWKdc:::::::::::::::::::::oKWMMMMMMMMM",
      @"XKKKKKKKKKKKKKKKKKKKXNMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWWWNXKK0Okxdc::::::::::::::::::::::o0WMMMMMMMM",
      @"MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWWNNXK00OOkxxdollcc:::::::::::::::::::::::::::::lOWMMMMMMM",
      @"MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWWNXXK0OOkxddollc:::::::::::::::::::::::::::::::::::::::::::ckNMMMMMM",
      @"MMMMMMMMMNXXNWMMMMMMMMWNNXK0OOkxxdolllcccccccccccccccccccccccccccccccccccccccccccccccccccccclkNMMMMM",
      @"MMMMMMMMXxlldKMMMMMMMWWNNXXXKKKKKKKKKKKXKKKKKKKKKXKKKKKKXXKKKXXXXXXXXXXKKKXXKKKKKKKKKKXXXXKKKXWMMMMM",
      @"MMMMMMMNxccccdXMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM",
      @"MMMMMMWOccxkcckNMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM",
      @"MMMMMW0l:dXNx:lOWMMMMMMMWXKKKKKKKKKKKKKNMMWXKXWMMMMMMMMMNXKXWMMMMNK0XWWX0O0XWMMMMWNKOOkOOKNWMMMMMMMM",
      @"MMMMMXo:oKWWKo:o0WMMMMMMXxlllllllllcccdKWMXd:oKMMMMMMMMM0lcxNMMMMKo:d0kolllkNMMW0xlllooolcokXWMMMMMM",
      @"MMMMNxclOWMMW0l:dXMMMMMMWNXXXXXXX0dccxXWMMXo:oKMMMMMMMMM0l:xNMMMM0l:lox0XXXNWMNkccx0XWWNXkl:oKWMMMMM",
      @"MMMNkccxNMMMMWkccxNMMMMMMMMMMMMWKdco0WMMMMXd:oKMMMMMMMMW0l:xNMMMM0l:cxNMMMMMMNkccONMMMMMMWOlckNMMMMM",
      @"MMW0l:oKNNNWWNKd:cOWMMMMMMMMMMNOlcxXWMMMMMXo:oKMMMMMMMMW0l:xNMMMM0l:oKMMMMMMW0l:lkOOOOOOOOxl:xNMMMMM",
      @"MMKo::cooooooool::l0WMMMMMMMWKdclONMMMMMMMXd:oKMMMMMMMMW0l:xNMMMM0l:dXMMMMMMWOl:cooooooooooodOWMMMMM",
      @"MXx:cdkkkkkkkkkkdc:oKMMMMMMNOocdKWMMMMMMMMXd:lKMMMMMMMMWOc:xNMMMM0l:dXMMMMMMW0l:dKNWWWWWWWWWWWMMMMMM",
      @"NkccxNMMMMMMMMMMNkccxXMMMWXxclONMMMMMMMMMMNx:cOWMMMMMMMXx::xNMMMW0l:dXMMMMMMMXx:cONMMMMMMMMMMMMMMMMM",
      @"Ol:oKWMMMMMMMMMMMXd:ckNMN0o:lkKXXXXXXXNWMMW0l:lkXNWWWX0dl::xNMMMW0l:dXMMMMMMMWKdccx0XNWWNNKO0NMMMMMM",
      @"ocl0WMMMMMMMMMMMMWKoco0Xklccclllllllllo0WMMW0dccloddoodkklcxNMMMMKocdXMMMMMMMMMNOdlcloooooloOWMMMMMM",
      @"Ok0NMMMMMMMMMMMMMMWKOOKX0OOkOOOOOOOOOOOXWMMMMN0xddddxOXWX0OKWMMMMN0k0WMMMMMMMMMMWN0kddddxk0XWMMMMMMM"
    };
    public string[] tieFArtArr = new[]
    {
      @"@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@&@@@@@@@@@@@@@@@@@@@@@@@@@@&@@@@@@@@@@@",
      @"@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@&@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@",
      @"@@@@@@@@@@@@@@@@@@@@@@@//@@@@@@@@@@@@@@@@@@@@@@@@@@@(&@@@@@@@@@@@@@@@@@@@@@@@@&@",
      @"@@@@@@@@@@@@@@@@@@&@@,@@#@@@#@@@@@@@@@@@@@@@@@@@@&@&/&/(@@@@@@@@@@@@@@@@@@@@@@@@",
      @"@@@@@@@@@@@@@@@@@@@(@@%@@@@@@@@@@@@&*,../@@@@@@@@@@@@&/&(,@@@@@@@@@@@@@@@@@@@@@@",
      @"@@@@@@@@@@@@@@@@@#@@%@@@@@@@@@@@...  .,  .,*,&@@@@@@@&&%/&%.@@@@@@@&@@@@@@@@&@@@",
      @"@@@@@@@@@@@@@@%/%%%%%&&@@&###  ,. ,(%###%/,**/ .,,(@@@//,*,,/,@@@@@@@@@@@@@@@@@@",
      @"@@@@@@@@@@@@@@@/#%%%%%%####*.  ,,#&@*&&#@@(#((.,.,,,*,****,,*,@@@@@@@@@@@@@@@@@@",
      @"@@@@@@@@@@@@@@@*&&%&@@@@@@#*(##/(&&%(#%(#(%%#%&&%(*/#%%&&(*((,@@@@@@@@@@@@@@@@@@",
      @"@@@@@@@@@@@@@@@*#%%%@@@@@@@&#%%((###&#&%&%&%%&&&&&&@@@@@&//*/,@@@@@@@@@@@@@@@@@@",
      @"@@@@@@@@@@@@@@@@(&&&&&@@@@@@@@@@@@&*&%/@%*@&@@@@@@@@@@&**(#/,@@@@%@@@@@@@@@@@@@@",
      @"@@@@@@@@@@@@@@@@@@#%&&@%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@**((#*@@@@@@@@@@@@@@@@@@@@@",
      @"@@@@@@@@@@@@@@@@@@@@@(&@@@@@@@@@@@@@@@@@@@@&@@@@@@@%*##*@@@@@@@@@@@@@@@@@@@@@@@@",
      @"@@@@@@@@@@@@@@@@@@@@@@@%#@@@@@@@@@@@@@@@@@@@@@@@@@@@*/@@@@@@@@@@@@@@@@@@@@@@@@@@",
      @"@@@@@@@@@@@@@@@@@@@@@@@&@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@",
      @"@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@"
    };
  }
}

