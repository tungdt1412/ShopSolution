﻿using ShopSolution.ViewModels.Common;
using ShopSolution.ViewModels.System.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopSolution.API
{
    public interface IUserApiClient
    {
        Task<ApiResult<string>> Authenticate(LoginRequest request);

        Task<ApiResult<PagedResult<UserVm>>> GetUserPaging(GetUserPagingRequest request);

        Task<ApiResult<bool>> RegisterUser(RegisterRequest registerRequest);

        Task<ApiResult<bool>> UpdateUser(Guid id, UserUpdateRequest registerRequest);

        Task<ApiResult<UserVm>> GetById(Guid id);

        Task<ApiResult<bool>> Delete(Guid id);

        Task<ApiResult<bool>> RoleAssign(Guid id, RoleAssignRequest request);
    }
}