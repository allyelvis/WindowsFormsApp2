{pkgs}: {
  deps = [
    pkgs.pwntools
    pkgs.nvidia-docker
    pkgs.dotnetCorePackages.sdk_3_0
  ];
}
